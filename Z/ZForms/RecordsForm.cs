using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.ZClasses;
using static System.Net.Mime.MediaTypeNames;

namespace Z.ZForms
{
    public partial class RecordsForm : Form
    {
        // Fields
        private Form? activeForm;

        // From other folder
        private ZClasses.PlaySound playSound;

        public RecordsForm()
        {
            InitializeComponent();

            playSound = new ZClasses.PlaySound();

            labelDisplayTitle.Visible = false;
        }

        private async void OpenChildForm(Form childForm) // Same code in MainForm
        {
            await playSound.xPlaySound();

            ActiveFormClose();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelRecordPane.Controls.Add(childForm);
            panelRecordPane.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            LabelDisplay("         Z-Data Grid");
            OpenChildForm(new ZRecordsForms.DataForm());
        }

        private void buttonOutline_Click(object sender, EventArgs e)
        {
            LabelDisplay(" Z-Pomodoro Count");
            OpenChildForm(new ZRecordsForms.ChartForm());
        }

        private async void buttonBack_Click(object sender, EventArgs e) // Same code in MainForm
        {
            labelDisplayTitle.Visible = false;

            await playSound.xPlaySound();

            ActiveFormClose();
        }

        private void ActiveFormClose()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void LabelDisplay(string text)
        {
            labelDisplayTitle.Text = text;
            labelDisplayTitle.Visible = true;
        }
    }
}
