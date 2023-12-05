using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.ZClasses;

namespace Z.ZForms
{
    public partial class TaskManagementForm : Form
    {
        // Fields and References
        private ZPomodoroForm zPomodoroForm;

        // From ZClasses Folder
        private ZClasses.PlaySound playSound;
        private ZClasses.BruhFormClass bruhForm;

        public TaskManagementForm(ZPomodoroForm zPomodoroForm)
        {
            InitializeComponent();

            this.zPomodoroForm = zPomodoroForm; // Assign the reference
            bruhForm = new BruhFormClass();
            playSound = new ZClasses.PlaySound();

            // Subscribe to the events from ZPomodoroForm
            zPomodoroForm.PomodoroStarted += ZPomodoroForm_PomodoroStarted;
            zPomodoroForm.PomodoroFinished += ZPomodoroForm_PomodoroFinished;
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            if (!string.IsNullOrEmpty(zPomodoroForm?.LabelText))
            {
                await bruhForm.ShowBruhForm("Finish...", this);
            }
            else if (string.IsNullOrEmpty(enterTaskTextBox.Text))
            {
                await bruhForm.ShowBruhForm("  Bruh...", this);
            }
            else
            {
                if (zPomodoroForm != null)
                {
                    zPomodoroForm.LabelText = enterTaskTextBox.Text;
                    enterTaskTextBox.Clear(); // clear text box
                    await bruhForm.ShowBruhForm(" Added...", this);
                }
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            enterTaskTextBox.Clear();

            await playSound.xPlaySound();

            // Clear the input assigned to zPomodoroForm.LabelText
            if (zPomodoroForm != null)
            {
                zPomodoroForm.LabelText = null;
                await bruhForm.ShowBruhForm("Deleted..." , this);
            }
        }

        private void ZPomodoroForm_PomodoroStarted(object sender, EventArgs e)
        {
            DisableDeleteButton(); // Disable delete button on Pomodoro start
        }

        private void ZPomodoroForm_PomodoroFinished(object sender, EventArgs e)
        {
            EnableDeleteButton(); // Enable delete button on Pomodoro finish
        }

        public void EnableDeleteButton()
        {
            if (buttonDelete != null)
            {
                buttonDelete.Enabled = true;
            }
        }

        public void DisableDeleteButton()
        {
            if (buttonDelete != null)
            {
                buttonDelete.Enabled = false;
            }
        }
    }
}
