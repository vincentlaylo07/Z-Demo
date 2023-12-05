using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.ZForms;

namespace Z.ZClasses
{
    public class BruhFormClass
    {
        public async Task ShowBruhForm(string errorMessage, Form mainForm)
        {
            ZForms.BruhForm bruhForm = new BruhForm();

            bruhForm.errorMessageLabel.Text = errorMessage;

            // Set the start position to manual
            bruhForm.StartPosition = FormStartPosition.Manual;

            // Calculate the position to center BruhForm in relation to the MainForm
            int x = mainForm.Location.X + (mainForm.Width - bruhForm.Width) / 2;
            int y = mainForm.Location.Y + (mainForm.Height - bruhForm.Height) / 2;

            // Screen coordinates
            Point screenPoint = mainForm.PointToScreen(new Point(x, y));

            // Set the position of BruhForm
            bruhForm.Location = screenPoint;

            bruhForm.Show();
            await Task.Delay(1200); // Delay

            // Start the timer to load panelBruh
            bruhForm.timer1.Start();

            // Close BruhForm
            bruhForm.Close();
        }
    }
}
