namespace Z
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            panelMenuButton = new Panel();
            buttonCredits = new Button();
            buttonRecords = new Button();
            buttonZPomodoro = new Button();
            buttonTaskManagement = new Button();
            panel1 = new Panel();
            panelLogo = new Panel();
            buttonZ = new Button();
            panelTitleBarMenu = new Panel();
            buttonCloseChildForm = new Button();
            buttonMinimize = new Button();
            buttonClose = new Button();
            labelTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelMenuButton.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBarMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(54, 59, 68);
            panelMenu.Controls.Add(panelMenuButton);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(130, 450);
            panelMenu.TabIndex = 0;
            // 
            // panelMenuButton
            // 
            panelMenuButton.Controls.Add(buttonCredits);
            panelMenuButton.Controls.Add(buttonRecords);
            panelMenuButton.Controls.Add(buttonZPomodoro);
            panelMenuButton.Controls.Add(buttonTaskManagement);
            panelMenuButton.Dock = DockStyle.Top;
            panelMenuButton.Location = new Point(0, 134);
            panelMenuButton.Name = "panelMenuButton";
            panelMenuButton.Size = new Size(130, 316);
            panelMenuButton.TabIndex = 6;
            // 
            // buttonCredits
            // 
            buttonCredits.Dock = DockStyle.Top;
            buttonCredits.FlatAppearance.BorderSize = 0;
            buttonCredits.FlatStyle = FlatStyle.Flat;
            buttonCredits.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonCredits.ForeColor = Color.FromArgb(200, 170, 110);
            buttonCredits.Location = new Point(0, 195);
            buttonCredits.Name = "buttonCredits";
            buttonCredits.Size = new Size(130, 65);
            buttonCredits.TabIndex = 4;
            buttonCredits.Text = "Credits";
            buttonCredits.UseVisualStyleBackColor = true;
            buttonCredits.Click += buttonCredits_Click;
            // 
            // buttonRecords
            // 
            buttonRecords.Dock = DockStyle.Top;
            buttonRecords.FlatAppearance.BorderSize = 0;
            buttonRecords.FlatStyle = FlatStyle.Flat;
            buttonRecords.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRecords.ForeColor = Color.FromArgb(200, 170, 110);
            buttonRecords.Location = new Point(0, 130);
            buttonRecords.Name = "buttonRecords";
            buttonRecords.Size = new Size(130, 65);
            buttonRecords.TabIndex = 3;
            buttonRecords.Text = "Records";
            buttonRecords.UseVisualStyleBackColor = true;
            buttonRecords.Click += buttonRecords_Click;
            // 
            // buttonZPomodoro
            // 
            buttonZPomodoro.Dock = DockStyle.Top;
            buttonZPomodoro.FlatAppearance.BorderSize = 0;
            buttonZPomodoro.FlatStyle = FlatStyle.Flat;
            buttonZPomodoro.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonZPomodoro.ForeColor = Color.FromArgb(200, 170, 110);
            buttonZPomodoro.Location = new Point(0, 65);
            buttonZPomodoro.Name = "buttonZPomodoro";
            buttonZPomodoro.Size = new Size(130, 65);
            buttonZPomodoro.TabIndex = 2;
            buttonZPomodoro.Text = "Z-Pomodoro";
            buttonZPomodoro.UseVisualStyleBackColor = true;
            buttonZPomodoro.Click += buttonZPomodoro_Click;
            // 
            // buttonTaskManagement
            // 
            buttonTaskManagement.Dock = DockStyle.Top;
            buttonTaskManagement.FlatAppearance.BorderSize = 0;
            buttonTaskManagement.FlatStyle = FlatStyle.Flat;
            buttonTaskManagement.Font = new Font("Beaufort for LOL", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonTaskManagement.ForeColor = Color.FromArgb(200, 170, 110);
            buttonTaskManagement.Location = new Point(0, 0);
            buttonTaskManagement.Name = "buttonTaskManagement";
            buttonTaskManagement.Size = new Size(130, 65);
            buttonTaskManagement.TabIndex = 1;
            buttonTaskManagement.Text = "Task Management";
            buttonTaskManagement.UseVisualStyleBackColor = true;
            buttonTaskManagement.Click += buttonTaskManagement_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 54);
            panel1.TabIndex = 5;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(46, 50, 58);
            panelLogo.Controls.Add(buttonZ);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(130, 80);
            panelLogo.TabIndex = 0;
            // 
            // buttonZ
            // 
            buttonZ.BackgroundImage = (Image)resources.GetObject("buttonZ.BackgroundImage");
            buttonZ.BackgroundImageLayout = ImageLayout.Zoom;
            buttonZ.Dock = DockStyle.Fill;
            buttonZ.FlatAppearance.BorderSize = 0;
            buttonZ.FlatStyle = FlatStyle.Flat;
            buttonZ.Location = new Point(0, 0);
            buttonZ.Name = "buttonZ";
            buttonZ.Size = new Size(130, 80);
            buttonZ.TabIndex = 4;
            buttonZ.UseVisualStyleBackColor = true;
            buttonZ.Click += buttonZ_Click;
            // 
            // panelTitleBarMenu
            // 
            panelTitleBarMenu.BackColor = Color.FromArgb(40, 44, 52);
            panelTitleBarMenu.Controls.Add(buttonCloseChildForm);
            panelTitleBarMenu.Controls.Add(buttonMinimize);
            panelTitleBarMenu.Controls.Add(buttonClose);
            panelTitleBarMenu.Controls.Add(labelTitle);
            panelTitleBarMenu.Dock = DockStyle.Top;
            panelTitleBarMenu.Location = new Point(130, 0);
            panelTitleBarMenu.Name = "panelTitleBarMenu";
            panelTitleBarMenu.Size = new Size(670, 80);
            panelTitleBarMenu.TabIndex = 1;
            panelTitleBarMenu.MouseDown += panelTitleBarMenu_MouseDown;
            // 
            // buttonCloseChildForm
            // 
            buttonCloseChildForm.BackgroundImage = (Image)resources.GetObject("buttonCloseChildForm.BackgroundImage");
            buttonCloseChildForm.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            buttonCloseChildForm.FlatStyle = FlatStyle.Flat;
            buttonCloseChildForm.Location = new Point(6, 32);
            buttonCloseChildForm.Name = "buttonCloseChildForm";
            buttonCloseChildForm.Size = new Size(20, 20);
            buttonCloseChildForm.TabIndex = 1;
            buttonCloseChildForm.UseVisualStyleBackColor = true;
            buttonCloseChildForm.Click += buttonCloseChildForm_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackgroundImage = (Image)resources.GetObject("buttonMinimize.BackgroundImage");
            buttonMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMinimize.ForeColor = Color.FromArgb(200, 170, 110);
            buttonMinimize.Location = new Point(611, 3);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(25, 25);
            buttonMinimize.TabIndex = 3;
            buttonMinimize.TextAlign = ContentAlignment.TopCenter;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.FromArgb(200, 170, 110);
            buttonClose.Location = new Point(642, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(25, 25);
            buttonClose.TabIndex = 2;
            buttonClose.TextAlign = ContentAlignment.TopCenter;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(200, 170, 110);
            labelTitle.Location = new Point(273, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(108, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "    Z-Main";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.FromArgb(240, 230, 210);
            panelDesktopPane.BackgroundImage = (Image)resources.GetObject("panelDesktopPane.BackgroundImage");
            panelDesktopPane.BackgroundImageLayout = ImageLayout.Stretch;
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(130, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(670, 370);
            panelDesktopPane.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBarMenu);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Z";
            panelMenu.ResumeLayout(false);
            panelMenuButton.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTitleBarMenu.ResumeLayout(false);
            panelTitleBarMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonTaskManagement;
        private Button buttonRecords;
        private Button buttonZPomodoro;
        private Panel panelTitleBarMenu;
        private Panel panelDesktopPane;
        private Label labelTitle;
        private Button buttonCloseChildForm;
        private Button buttonClose;
        private Button buttonMinimize;
        private PictureBox pictureBox1;
        private Button buttonZ;
        private Button buttonCredits;
        private Panel panel1;
        private Panel panelMenuButton;
    }
}