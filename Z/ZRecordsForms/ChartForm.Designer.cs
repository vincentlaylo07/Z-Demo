namespace Z.ZRecordsForms
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // chart
            // 
            chart.BackColor = Color.FromArgb(240, 230, 210);
            chart.BackSecondaryColor = Color.FromArgb(240, 230, 210);
            chartArea1.BackColor = Color.FromArgb(240, 230, 210);
            chartArea1.BackSecondaryColor = Color.FromArgb(240, 230, 210);
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Fill;
            legend1.BackColor = Color.FromArgb(240, 230, 210);
            legend1.Font = new Font("Beaufort for LOL", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            legend1.ForeColor = Color.FromArgb(60, 60, 65);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BackImageTransparentColor = Color.FromArgb(240, 230, 210);
            series1.BackSecondaryColor = Color.FromArgb(240, 230, 210);
            series1.BorderColor = Color.FromArgb(240, 230, 210);
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = Color.FromArgb(240, 230, 210);
            series1.Font = new Font("Beaufort for LOL", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            series1.LabelForeColor = Color.FromArgb(60, 60, 65);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 6;
            chart.Series.Add(series1);
            chart.Size = new Size(490, 270);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 270);
            panel1.TabIndex = 1;
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(240, 230, 210);
            ClientSize = new Size(490, 270);
            Controls.Add(chart);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChartForm";
            Text = "ChartForm";
            Load += ChartForm_Load;
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Panel panel1;
    }
}