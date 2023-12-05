namespace Z
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            panel1 = new Panel();
            panelProgressBar = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            Loading = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelProgressBar);
            panel1.Location = new Point(1, 425);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            // 
            // panelProgressBar
            // 
            panelProgressBar.BackColor = Color.FromArgb(53, 57, 65);
            panelProgressBar.Location = new Point(-5, 0);
            panelProgressBar.Name = "panelProgressBar";
            panelProgressBar.Size = new Size(50, 25);
            panelProgressBar.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // Loading
            // 
            Loading.AutoSize = true;
            Loading.BackColor = Color.Transparent;
            Loading.Font = new Font("Beaufort for LOL", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Loading.ForeColor = Color.FromArgb(200, 170, 110);
            Loading.Location = new Point(640, 382);
            Loading.Name = "Loading";
            Loading.Size = new Size(158, 40);
            Loading.TabIndex = 1;
            Loading.Text = "Loading ...";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 250;
            timer2.Tick += timer2_Tick;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 2;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(Loading);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SplashScreen_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Label Loading;
        private System.Windows.Forms.Timer timer2;
        private Panel panel2;
    }
}