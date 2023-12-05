namespace Z.ZForms
{
    partial class BruhForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BruhForm));
            panel1 = new Panel();
            panelBruh = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            errorMessageLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 60, 65);
            panel1.Controls.Add(panelBruh);
            panel1.Location = new Point(-1, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 25);
            panel1.TabIndex = 0;
            // 
            // panelBruh
            // 
            panelBruh.BackColor = Color.FromArgb(200, 170, 110);
            panelBruh.Location = new Point(0, 0);
            panelBruh.Name = "panelBruh";
            panelBruh.Size = new Size(10, 25);
            panelBruh.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.BackColor = Color.Transparent;
            errorMessageLabel.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            errorMessageLabel.ForeColor = Color.FromArgb(60, 60, 65);
            errorMessageLabel.Location = new Point(46, 127);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(0, 26);
            errorMessageLabel.TabIndex = 1;
            // 
            // BruhForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(184, 181);
            Controls.Add(errorMessageLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BruhForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelBruh;
        public System.Windows.Forms.Timer timer1;
        public Label errorMessageLabel;
    }
}