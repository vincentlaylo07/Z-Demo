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
    public partial class DataForm : Form
    {
        // Fields
        private ZClasses.DatabaseClass databaseClass;
        private ZClasses.BruhFormClass bruhFormClass;
        private ZClasses.PlaySound playSound;

        // Constructor
        public DataForm()
        {
            InitializeComponent();

            databaseClass = new ZClasses.DatabaseClass();
            bruhFormClass = new ZClasses.BruhFormClass();
            playSound = new ZClasses.PlaySound();
        }

        private async void LoadZRecords()
        {
            DataTable dataTableZRecords = databaseClass.LoadDataGridTable();
            if (dataTableZRecords != null && dataTableZRecords.Rows.Count > 0)
            {
                dataGridView.DataSource = dataTableZRecords;
                dataGridView.ReadOnly = true;

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.Width = 130;
                }
            }
            else
            {
                await bruhFormClass.ShowBruhForm("No Rec...", this);
            }
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            LoadZRecords();
        }

        public async void SearchData(string valueToSearch)
        {
            DataTable searchResult = databaseClass.SearchData(valueToSearch);

            if (searchResult != null && searchResult.Rows.Count > 0)
            {
                dataGridView.DataSource = searchResult;
            }
            else
            {
                await bruhFormClass.ShowBruhForm("No Rec...", this);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchData("");
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            await playSound.xPlaySound();

            string valueToSearch = textBoxSearch.Text.ToString();
            SearchData(valueToSearch);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
                e.SuppressKeyPress = true; // Suppress the Enter key
            }
        }
    }
}