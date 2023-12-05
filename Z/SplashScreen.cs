namespace Z
{
    public partial class SplashScreen : Form
    {
        // Fields
        private string text;
        private int len = 0;

        // From ZClasses
        private ZClasses.PlaySound playSound;

        // Constructor
        public SplashScreen()
        {
            InitializeComponent();
            playSound = new ZClasses.PlaySound();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increase the width of the progress bar panel
            panelProgressBar.Width += 5;

            // Check if the progress bar width has reached the desired value
            if (panelProgressBar.Width >= 1050)
            {
                // Stop the timer, create a new MainForm, show it, and hide the SplashScreen
                timer1.Stop();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Check if there are characters left to display
            if (len < text.Length)
            {
                // Add the next character to the Loading label and increment the index
                Loading.Text = Loading.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                // Stop the timer when all characters are displayed
                timer2.Stop();
            }
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            // Save the initial text of the Loading label, clear it, and start the second timer
            text = Loading.Text;
            Loading.Text = "";
            timer2.Start();

            // Delay for .8 second
            await Task.Delay(800);
            await playSound.vPlaySound();
        }
    }
}
