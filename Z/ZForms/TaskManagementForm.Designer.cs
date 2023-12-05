namespace Z.ZForms
{
    partial class TaskManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagementForm));
            labelTitle = new Label();
            enterTaskTextBox = new TransparentBackgroundTextBox();
            labelEnterTask = new Label();
            buttonAdd = new Button();
            buttonDelete = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Beaufort for LOL", 27.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(60, 60, 65);
            labelTitle.Location = new Point(64, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(537, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Accomplish a task with efficiency";
            // 
            // enterTaskTextBox
            // 
            enterTaskTextBox.BackColor = Color.FromArgb(240, 230, 210);
            enterTaskTextBox.BorderStyle = BorderStyle.None;
            enterTaskTextBox.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            enterTaskTextBox.ForeColor = Color.FromArgb(60, 60, 65);
            enterTaskTextBox.Location = new Point(310, 130);
            enterTaskTextBox.MaxLength = 25;
            enterTaskTextBox.Name = "enterTaskTextBox";
            enterTaskTextBox.Size = new Size(200, 31);
            enterTaskTextBox.TabIndex = 1;
            // 
            // labelEnterTask
            // 
            labelEnterTask.AutoSize = true;
            labelEnterTask.Font = new Font("Beaufort for LOL", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEnterTask.ForeColor = Color.FromArgb(60, 60, 65);
            labelEnterTask.Location = new Point(144, 130);
            labelEnterTask.Name = "labelEnterTask";
            labelEnterTask.Size = new Size(160, 30);
            labelEnterTask.TabIndex = 2;
            labelEnterTask.Text = "Enter the task:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(54, 59, 68);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.FromArgb(200, 170, 110);
            buttonAdd.Location = new Point(174, 230);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 40);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(54, 59, 68);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Beaufort for LOL", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.FromArgb(200, 170, 110);
            buttonDelete.Location = new Point(380, 230);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 40);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 370);
            panel1.TabIndex = 8;
            // 
            // TaskManagementForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(240, 230, 210);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(670, 370);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(labelEnterTask);
            Controls.Add(enterTaskTextBox);
            Controls.Add(labelTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskManagementForm";
            Text = "    Z-Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelEnterTask;
        private Button buttonAdd;
        public Button buttonDelete;
        public TransparentBackgroundTextBox enterTaskTextBox;
        private Panel panel1;
    }
}