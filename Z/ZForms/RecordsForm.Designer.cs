namespace Z.ZForms
{
    partial class RecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsForm));
            panelRecordPane = new Panel();
            pictureBox1 = new PictureBox();
            buttonData = new Button();
            buttonOutline = new Button();
            buttonBack = new Button();
            labelDisplayTitle = new Label();
            panel1 = new Panel();
            panelRecordPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelRecordPane
            // 
            panelRecordPane.BackgroundImage = (Image)resources.GetObject("panelRecordPane.BackgroundImage");
            panelRecordPane.BackgroundImageLayout = ImageLayout.Zoom;
            panelRecordPane.Controls.Add(pictureBox1);
            panelRecordPane.Location = new Point(55, 45);
            panelRecordPane.Name = "panelRecordPane";
            panelRecordPane.Size = new Size(490, 270);
            panelRecordPane.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(245, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 180);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonData
            // 
            buttonData.BackColor = Color.FromArgb(54, 59, 68);
            buttonData.FlatAppearance.BorderSize = 0;
            buttonData.FlatStyle = FlatStyle.Flat;
            buttonData.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonData.ForeColor = Color.FromArgb(200, 170, 110);
            buttonData.Location = new Point(558, 95);
            buttonData.Name = "buttonData";
            buttonData.Size = new Size(100, 40);
            buttonData.TabIndex = 7;
            buttonData.Text = "Data";
            buttonData.UseVisualStyleBackColor = false;
            buttonData.Click += buttonData_Click;
            // 
            // buttonOutline
            // 
            buttonOutline.BackColor = Color.FromArgb(54, 59, 68);
            buttonOutline.FlatAppearance.BorderSize = 0;
            buttonOutline.FlatStyle = FlatStyle.Flat;
            buttonOutline.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonOutline.ForeColor = Color.FromArgb(200, 170, 110);
            buttonOutline.Location = new Point(558, 160);
            buttonOutline.Name = "buttonOutline";
            buttonOutline.Size = new Size(100, 40);
            buttonOutline.TabIndex = 8;
            buttonOutline.Text = "Outline";
            buttonOutline.UseVisualStyleBackColor = false;
            buttonOutline.Click += buttonOutline_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(54, 59, 68);
            buttonBack.BackgroundImage = (Image)resources.GetObject("buttonBack.BackgroundImage");
            buttonBack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.FromArgb(200, 170, 110);
            buttonBack.Location = new Point(558, 225);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 40);
            buttonBack.TabIndex = 9;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelDisplayTitle
            // 
            labelDisplayTitle.AutoSize = true;
            labelDisplayTitle.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelDisplayTitle.ForeColor = Color.FromArgb(60, 60, 65);
            labelDisplayTitle.Location = new Point(235, 9);
            labelDisplayTitle.Name = "labelDisplayTitle";
            labelDisplayTitle.Size = new Size(0, 26);
            labelDisplayTitle.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 370);
            panel1.TabIndex = 11;
            // 
            // RecordsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(240, 230, 210);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(670, 370);
            Controls.Add(panelRecordPane);
            Controls.Add(labelDisplayTitle);
            Controls.Add(buttonBack);
            Controls.Add(buttonOutline);
            Controls.Add(buttonData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecordsForm";
            Text = "Z-Records";
            panelRecordPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRecordPane;
        private Button buttonData;
        private Button buttonOutline;
        private Button buttonBack;
        private Label labelDisplayTitle;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}