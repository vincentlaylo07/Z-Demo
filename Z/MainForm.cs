using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using Z.ZForms;
using Z.ZClasses;

namespace Z
{
    public partial class MainForm : Form
    {
        // Fields
        private Button currentButton; // Represents the currently selected button in the menu
        public Form? activeForm; // Tracks the currently active child form

        // From ZForms
        private ZForms.TaskManagementForm taskManagementForm;
        private ZForms.ZPomodoroForm zPomodoroForm;
        private ZForms.RecordsForm recordsForm;
        private ZForms.CreditsForm creditsForm;

        // From ZClasses
        private ZClasses.PlaySound playSound;
        private ZClasses.LinkClass linkClass;

        public MainForm()
        {
            InitializeComponent();
            buttonCloseChildForm.Visible = false; // Initially hides the X button

            // Initialize the form instances
            zPomodoroForm = new ZForms.ZPomodoroForm();
            taskManagementForm = new ZForms.TaskManagementForm(zPomodoroForm); // Pass the ZPomodoroForm instance
            recordsForm = new ZForms.RecordsForm();
            creditsForm = new CreditsForm();
            playSound = new ZClasses.PlaySound();
            linkClass = new LinkClass();
        }

        // To drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Sets the theme color for button backgrounds
        private Color SetThemeColor()
        {
            return ColorTranslator.FromHtml("#282c34");
        }

        // Activates the selected button in the menu
        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton(); // Disables previously active buttons
                    Color color = SetThemeColor();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = color; // Sets the background color for the selected button
                    buttonCloseChildForm.Visible = true; // Shows the close button for the selected form
                }
            }
        }

        // Disables all buttons in the menu
        private void DisableButton()
        {
            foreach (Control previousButton in panelMenuButton.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(54, 59, 68); // Resets button background color
                }
            }
        }

        // Open child form in the panel
        private async void OpenChildForm(Form childForm, object buttonSender)
        {
            if (panelDesktopPane.Controls.Count > 0)
            {
                panelDesktopPane.Controls.RemoveAt(0); // Remove the existing form from the panel
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktopPane.Controls.Add(childForm); // Adds the child form to the panel
            panelDesktopPane.Tag = childForm;

            childForm.BringToFront(); // Brings the child form to the front
            childForm.Show(); // Displays the child form

            labelTitle.Text = childForm.Text; // Sets the title label text

            ActivateButton(buttonSender); // Activates the corresponding menu button

            await playSound.zPlaySound(); // Play sound
        }

        // Button click events to open specific child forms
        private void buttonTaskManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(taskManagementForm, sender);
        }

        private void buttonZPomodoro_Click(object sender, EventArgs e)
        {
            OpenChildForm(zPomodoroForm, sender);
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            OpenChildForm(recordsForm, sender);
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            OpenChildForm(creditsForm, sender);
        }

        // Closes the active child form and resets UI elements
        private async void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null) // Check if the active form is not the MainForm
            {
                activeForm.Close();
            }
            else
            {
                Reset(); // Resets UI elements
            }

            await playSound.zPlaySound();
        }

        // Resets UI elements to default state
        private void Reset()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            DisableButton(); // Resets button colors
            labelTitle.Text = "    Z-Main"; // Resets title label text
            currentButton = null;
            buttonCloseChildForm.Visible = false; // Hides the close button

            // Clear the child form from the panel
            if (panelDesktopPane.Controls.Count > 0)
            {
                panelDesktopPane.Controls.RemoveAt(0);
            }
        }

        private void panelTitleBarMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            linkClass.WebsiteLink("https://www.youtube.com/watch?v=C3GouGa0noM&list=RDC3GouGa0noM&start_radio=1&ab_channel=LeagueofLegends");
        }
    }
}