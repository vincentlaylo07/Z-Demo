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

namespace Z.ZForms
{
    public partial class CreditsForm : Form
    {
        private ZClasses.LinkClass linkClass;

        public CreditsForm()
        {
            InitializeComponent();

            linkClass = new LinkClass();
        }
        private void buttonTheme_Click(object sender, EventArgs e)
        {
            linkClass.WebsiteLink("https://brand.riotgames.com/en-us/league-of-legends/fundamentals");
        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {
            linkClass.WebsiteLink("https://www.facebook.com/johnvincent.laylo.7");
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            linkClass.WebsiteLink("https://www.leagueoflegends.com/en-ph/");
        }
    }
}
