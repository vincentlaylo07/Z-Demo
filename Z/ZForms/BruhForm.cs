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

namespace Z.ZForms
{
    public partial class BruhForm : Form
    {
        public BruhForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increase the width of the progress bar panel
            panelBruh.Width += 5;

            // Check if the progress bar width has reached the desired value
            if (panelBruh.Width >= 220)
            {
                timer1.Stop();
                Hide();
            }
        }
    }
}
