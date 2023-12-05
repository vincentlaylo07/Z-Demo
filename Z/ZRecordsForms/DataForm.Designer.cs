namespace Z.ZRecordsForms
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            textBoxSearch = new TransparentBackgroundTextBox();
            label1 = new Label();
            buttonSearch = new Button();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 230, 210);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 40);
            panel1.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.Transparent;
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.FromArgb(60, 60, 65);
            textBoxSearch.Location = new Point(65, 10);
            textBoxSearch.MaxLength = 30;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(110, 25);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(60, 60, 65);
            label1.Location = new Point(-3, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(240, 230, 210);
            buttonSearch.BackgroundImage = (Image)resources.GetObject("buttonSearch.BackgroundImage");
            buttonSearch.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = Color.FromArgb(240, 230, 210);
            buttonSearch.Location = new Point(181, 10);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(25, 25);
            buttonSearch.TabIndex = 2;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(200, 170, 110);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 44, 52);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 44, 52);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(200, 170, 110);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = Color.FromArgb(240, 230, 210);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(54, 59, 68);
            dataGridViewCellStyle2.Font = new Font("Beaufort for LOL", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(200, 170, 110);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(200, 170, 110);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(54, 59, 68);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(240, 230, 210);
            dataGridViewCellStyle3.Font = new Font("Beaufort for LOL", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(60, 60, 65);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 60, 65);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(240, 230, 210);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(40, 44, 52);
            dataGridView.Location = new Point(0, 40);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(490, 230);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 270);
            panel2.TabIndex = 3;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(240, 230, 210);
            ClientSize = new Size(490, 270);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataForm";
            Text = "DataForm";
            Load += DataForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView;
        private TransparentBackgroundTextBox textBoxSearch;
        private Button buttonSearch;
        private Label label1;
        private Panel panel2;
    }
}