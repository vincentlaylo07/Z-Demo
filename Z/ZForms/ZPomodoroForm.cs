using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.ZClasses;

namespace Z.ZForms
{
    public partial class ZPomodoroForm : Form
    {
        // Fields

        // From ZClasses
        private ZClasses.DatabaseClass databaseClass;
        private ZClasses.PlaySound playSound;

        // Events for start and finish actions
        public event EventHandler PomodoroStarted;
        public event EventHandler PomodoroFinished;

        private BruhFormClass bruhForm;

        // Time intervals and countdown

        // For demo 25 sec.
        private const int WORK_TIME = 25;
        private const int SHORT_BREAK_TIME = 5;
        private const int LONG_BREAK_TIME = 15;

        // Real code
        //private const int WORK_TIME = 25 * 60;
        //private const int SHORT_BREAK_TIME = 5 * 60;
        //private const int LONG_BREAK_TIME = 15 * 60;

        private int workTimeRemaining;
        private int breakTimeRemaining;

        // Flags to track the Pomodoro session state
        private bool isWorkTime = true;
        private int pomodorosCompleted = 0;
        private bool isRunning = false;

        // To access start time in finishButton
        private string? startTime;

        // Field to store label text internally
        private string _labelText;

        // Property to manage the label text
        public string? LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value; // Set the internal field to the provided value
                labelToFinishTask.Text = value; // Set the text of labelToFinishTask to the provided value
                UpdateLabelVisibility(); // Update the visibility of labelToFinishDisplay based on the text
            }
        }

        // Constructor
        public ZPomodoroForm()
        {
            InitializeComponent();

            timer1.Tick += Timer_Tick; // Subscribe to the Tick event of timer1

            databaseClass = new ZClasses.DatabaseClass();
            playSound = new ZClasses.PlaySound();
            bruhForm = new BruhFormClass();
        }

        private void ZPomodoroForm_Load(object sender, EventArgs e)
        {
            // Disabled buttons 
            buttonFinish.Enabled = false; 
            buttonPause.Enabled = false;

            UpdateLabelVisibility();
        }

        // Method to update the visibility of labelToFinishDisplay based on the label text
        private void UpdateLabelVisibility()
        {
            if (!string.IsNullOrWhiteSpace(_labelText))
            {
                labelToFinishDisplay.Visible = true;
            }
            else
            {
                labelToFinishDisplay.Visible = false;
            }
        }

        // Timer tick event handling Pomodoro logic
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                if (isWorkTime)
                {
                    workTimeRemaining--;
                    if (workTimeRemaining == 0)
                    {
                        isWorkTime = false;
                        pomodorosCompleted++;
                        breakTimeRemaining = (pomodorosCompleted % 4 == 0) ? LONG_BREAK_TIME : SHORT_BREAK_TIME;
                        playSound.cPlaySound();

                        UpdateLabelToDo(); // Update labelToDo based on current state
                        labelPomodoroCount.Text = pomodorosCompleted.ToString();
                    }
                }
                else
                {
                    breakTimeRemaining--;
                    if (breakTimeRemaining == 0)
                    {
                        isWorkTime = true;
                        workTimeRemaining = WORK_TIME;

                        playSound.cPlaySound();
                        UpdateLabelToDo(); // Update labelToDo based on current state
                    }
                }
                UpdateTimerLabel();
            }
        }

        private void UpdateLabelToDo()
        {
            if (isWorkTime)
            {
                labelToDo.Text = "     Work";
            }
            else
            {
                if (pomodorosCompleted % 4 == 0)
                {
                    labelToDo.Text = "Long Break";
                }
                else
                {
                    labelToDo.Text = "Short Break";
                }
            }
        }

        // Method to update the timer label text
        private void UpdateTimerLabel()
        {
            if (isRunning)
            {
                // Display the remaining time in the label
                if (isWorkTime)
                {
                    TimeSpan workTime = TimeSpan.FromSeconds(workTimeRemaining);
                    timeLabel.Text = $"{workTime.Minutes:00}:{workTime.Seconds:00}";
                }
                else
                {
                    TimeSpan breakTime = TimeSpan.FromSeconds(breakTimeRemaining);
                    timeLabel.Text = $"{breakTime.Minutes:00}:{breakTime.Seconds:00}";
                }
            }
            else
            {
                // Display the initial time of 25:00 when the timer is stopped
                TimeSpan initialTime = TimeSpan.FromSeconds(WORK_TIME);
                timeLabel.Text = $"{initialTime.Minutes:00}:{initialTime.Seconds:00}";
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            if (LabelText == null)
            {
                await bruhForm.ShowBruhForm("  Bruh...", this);
            }
            else
            {
                startTime = DateTime.Now.ToString("HH:mm:ss");

                PomodoroStarted?.Invoke(this, EventArgs.Empty); // Trigger the start event

                // From flags
                isRunning = true;
                buttonStart.Enabled = false;
                buttonPause.Enabled = true;
                buttonFinish.Enabled = true;

                // Start with the initial countdown values
                workTimeRemaining = WORK_TIME;
                breakTimeRemaining = SHORT_BREAK_TIME;

                UpdateLabelToDo();
                UpdateTimerLabel();
                timer1.Start();
            }
        }

        private async void buttonFinish_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            string toFinishTask = LabelText ?? "";
            int taskId = databaseClass.InsertTaskNameAndGetId(toFinishTask);

            DateTime currentDate = DateTime.Now; // Current date and time
            string finishTime = DateTime.Now.ToString("HH:mm:ss"); // Get finish Time

            // Calculate the time span between start and finish time
            TimeSpan timeDifference = DateTime.Parse(finishTime) - DateTime.Parse(startTime);
            string spentTime = timeDifference.ToString(@"hh\:mm\:ss");

            string getPomodoroCount = labelPomodoroCount.Text;
            int pomodoroCount = int.Parse(getPomodoroCount);

            // To Insert
            databaseClass.InsertToTimeRecords(taskId, currentDate, TimeSpan.Parse(startTime), TimeSpan.Parse(finishTime), TimeSpan.Parse(spentTime));
            databaseClass.InsertToPomodoroSessions(taskId, pomodoroCount); 

            PomodoroFinished?.Invoke(this, EventArgs.Empty); // Trigger the finish event

            // Update flags
            isRunning = false;
            buttonStart.Enabled = true;
            buttonPause.Enabled = false;
            buttonFinish.Enabled = false;

            timer1.Stop();

            // Reset all timer logic
            isWorkTime = true;
            pomodorosCompleted = 0;
            timeLabel.Text = "25:00";
            LabelText = null;
            labelPomodoroCount.Text = "0";

            breakTimeRemaining = (pomodorosCompleted % 4 == 0) ? LONG_BREAK_TIME : SHORT_BREAK_TIME;

            startTime = null;

            // Show Fern
            await bruhForm.ShowBruhForm("  Done...", this);
        }

        private async void buttonPause_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();
          
            await bruhForm.ShowBruhForm("Pause?...", this);
        }
    }
}