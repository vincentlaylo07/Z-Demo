namespace Z.ZForms
{
    partial class CreditsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsForm));
            label1 = new Label();
            buttonTheme = new Button();
            buttonCreator = new Button();
            buttonCredits = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(60, 60, 65);
            label1.Location = new Point(80, 45);
            label1.Name = "label1";
            label1.Size = new Size(519, 156);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonTheme
            // 
            buttonTheme.BackColor = Color.FromArgb(54, 59, 68);
            buttonTheme.FlatAppearance.BorderSize = 0;
            buttonTheme.FlatStyle = FlatStyle.Flat;
            buttonTheme.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonTheme.ForeColor = Color.FromArgb(200, 170, 110);
            buttonTheme.Location = new Point(132, 246);
            buttonTheme.Name = "buttonTheme";
            buttonTheme.Size = new Size(100, 40);
            buttonTheme.TabIndex = 8;
            buttonTheme.Text = "Theme";
            buttonTheme.UseVisualStyleBackColor = false;
            buttonTheme.Click += buttonTheme_Click;
            // 
            // buttonCreator
            // 
            buttonCreator.BackColor = Color.FromArgb(54, 59, 68);
            buttonCreator.FlatAppearance.BorderSize = 0;
            buttonCreator.FlatStyle = FlatStyle.Flat;
            buttonCreator.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCreator.ForeColor = Color.FromArgb(200, 170, 110);
            buttonCreator.Location = new Point(285, 246);
            buttonCreator.Name = "buttonCreator";
            buttonCreator.Size = new Size(100, 40);
            buttonCreator.TabIndex = 9;
            buttonCreator.Text = "Z-Creator";
            buttonCreator.UseVisualStyleBackColor = false;
            buttonCreator.Click += buttonCreator_Click;
            // 
            // buttonCredits
            // 
            buttonCredits.BackColor = Color.FromArgb(54, 59, 68);
            buttonCredits.FlatAppearance.BorderSize = 0;
            buttonCredits.FlatStyle = FlatStyle.Flat;
            buttonCredits.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCredits.ForeColor = Color.FromArgb(200, 170, 110);
            buttonCredits.Location = new Point(439, 246);
            buttonCredits.Name = "buttonCredits";
            buttonCredits.Size = new Size(100, 40);
            buttonCredits.TabIndex = 10;
            buttonCredits.Text = "Credits";
            buttonCredits.UseVisualStyleBackColor = false;
            buttonCredits.Click += buttonCredits_Click;
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
            // CreditsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(240, 230, 210);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(670, 370);
            Controls.Add(buttonCredits);
            Controls.Add(buttonCreator);
            Controls.Add(buttonTheme);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreditsForm";
            Text = "Z-Credits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Button buttonTheme;
        public Button buttonCreator;
        public Button buttonCredits;
        private Panel panel1;
    }
}