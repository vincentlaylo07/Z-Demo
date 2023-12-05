namespace Z.ZForms
{
    partial class ZPomodoroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZPomodoroForm));
            labelToFinishDisplay = new Label();
            labelToFinishTask = new Label();
            timeLabel = new Label();
            panel1 = new Panel();
            buttonStart = new Button();
            buttonPause = new Button();
            buttonFinish = new Button();
            labelToDo = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            labelZPomodoros = new Label();
            labelPomodoroCount = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelToFinishDisplay
            // 
            labelToFinishDisplay.AutoSize = true;
            labelToFinishDisplay.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelToFinishDisplay.ForeColor = Color.FromArgb(60, 60, 65);
            labelToFinishDisplay.Location = new Point(247, 30);
            labelToFinishDisplay.Name = "labelToFinishDisplay";
            labelToFinishDisplay.Size = new Size(102, 26);
            labelToFinishDisplay.TabIndex = 0;
            labelToFinishDisplay.Text = "To Finish: ";
            // 
            // labelToFinishTask
            // 
            labelToFinishTask.AutoSize = true;
            labelToFinishTask.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelToFinishTask.ForeColor = Color.FromArgb(60, 60, 65);
            labelToFinishTask.Location = new Point(340, 30);
            labelToFinishTask.Name = "labelToFinishTask";
            labelToFinishTask.Size = new Size(0, 26);
            labelToFinishTask.TabIndex = 1;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Beaufort for LOL", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.FromArgb(200, 170, 110);
            timeLabel.Location = new Point(32, 25);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(137, 60);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "25:00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(timeLabel);
            panel1.Location = new Point(235, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 110);
            panel1.TabIndex = 3;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(54, 59, 68);
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.FromArgb(200, 170, 110);
            buttonStart.Location = new Point(490, 79);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(100, 40);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonPause
            // 
            buttonPause.BackColor = Color.FromArgb(54, 59, 68);
            buttonPause.FlatAppearance.BorderSize = 0;
            buttonPause.FlatStyle = FlatStyle.Flat;
            buttonPause.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonPause.ForeColor = Color.FromArgb(200, 170, 110);
            buttonPause.Location = new Point(490, 135);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(100, 40);
            buttonPause.TabIndex = 8;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = false;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonFinish
            // 
            buttonFinish.BackColor = Color.FromArgb(54, 59, 68);
            buttonFinish.FlatAppearance.BorderSize = 0;
            buttonFinish.FlatStyle = FlatStyle.Flat;
            buttonFinish.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonFinish.ForeColor = Color.FromArgb(200, 170, 110);
            buttonFinish.Location = new Point(490, 191);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(100, 40);
            buttonFinish.TabIndex = 9;
            buttonFinish.Text = "Finish";
            buttonFinish.UseVisualStyleBackColor = false;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // labelToDo
            // 
            labelToDo.AutoSize = true;
            labelToDo.BackColor = Color.Transparent;
            labelToDo.Font = new Font("Beaufort for LOL Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            labelToDo.ForeColor = Color.FromArgb(60, 60, 65);
            labelToDo.Location = new Point(273, 210);
            labelToDo.Name = "labelToDo";
            labelToDo.Size = new Size(78, 30);
            labelToDo.TabIndex = 10;
            labelToDo.Text = "        ▲";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // labelZPomodoros
            // 
            labelZPomodoros.AutoSize = true;
            labelZPomodoros.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelZPomodoros.ForeColor = Color.FromArgb(60, 60, 65);
            labelZPomodoros.Location = new Point(235, 265);
            labelZPomodoros.Name = "labelZPomodoros";
            labelZPomodoros.Size = new Size(175, 34);
            labelZPomodoros.TabIndex = 12;
            labelZPomodoros.Text = "Z-Pomodoros:";
            // 
            // labelPomodoroCount
            // 
            labelPomodoroCount.AutoSize = true;
            labelPomodoroCount.Font = new Font("Beaufort for LOL", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPomodoroCount.ForeColor = Color.FromArgb(60, 60, 65);
            labelPomodoroCount.Location = new Point(405, 265);
            labelPomodoroCount.Name = "labelPomodoroCount";
            labelPomodoroCount.Size = new Size(29, 34);
            labelPomodoroCount.TabIndex = 13;
            labelPomodoroCount.Text = "0";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 370);
            panel2.TabIndex = 14;
            // 
            // ZPomodoroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 230, 210);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(670, 370);
            Controls.Add(labelPomodoroCount);
            Controls.Add(labelZPomodoros);
            Controls.Add(labelToFinishTask);
            Controls.Add(labelToFinishDisplay);
            Controls.Add(labelToDo);
            Controls.Add(buttonFinish);
            Controls.Add(buttonPause);
            Controls.Add(buttonStart);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZPomodoroForm";
            Text = "Z-Pomodoro";
            Load += ZPomodoroForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelToFinishDisplay;
        private Label labelToFinishTask;
        private Label timeLabel;
        private Panel panel1;
        private Button buttonStart;
        private Button buttonPause;
        private Button buttonFinish;
        private Label labelToDo;
        private PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private Label labelZPomodoros;
        private Label labelPomodoroCount;
        private Panel panel2;
    }
}