using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z.ZRecordsForms
{
    public partial class ChartForm : Form
    {
        // Fields
        private ZClasses.DatabaseClass databaseClass;
        private ZClasses.BruhFormClass bruhFormClass;

        public ChartForm()
        {
            InitializeComponent();

            databaseClass = new ZClasses.DatabaseClass();
            bruhFormClass = new ZClasses.BruhFormClass();
        }

        private async void ChartForm_Load(object sender, EventArgs e)
        {
            DataTable chartData = databaseClass.ChartDataPerDay(); // Real Query ChartDataPerYear();

            if (chartData != null && chartData.Rows.Count > 0)
            {
                chart.Series[0].XValueMember = "CurrentDate";
                chart.Series[0].YValueMembers = "TotalPomodoroCount"; // Assuming this column name from the method

                // Real Query
                //chart.Series[0].XValueMember = "Year"; 
                //chart.Series[0].YValueMembers = "TotalPomodoroCount";

                chart.Series[0].IsValueShownAsLabel = true;

                chart.DataSource = chartData;
                chart.DataBind();
            }
            else
            {
                await bruhFormClass.ShowBruhForm("No Rec...", this);
            }
        }

    }
}
