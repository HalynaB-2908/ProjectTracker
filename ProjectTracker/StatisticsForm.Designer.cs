namespace ProjectTracker
{
    partial class StatisticsForm
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
            this.weeklyRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.monthlyRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyRadioButton
            // 
            this.weeklyRadioButton.AutoSize = true;
            this.weeklyRadioButton.Depth = 0;
            this.weeklyRadioButton.Location = new System.Drawing.Point(54, 178);
            this.weeklyRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.weeklyRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.weeklyRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.weeklyRadioButton.Name = "weeklyRadioButton";
            this.weeklyRadioButton.Ripple = true;
            this.weeklyRadioButton.Size = new System.Drawing.Size(85, 37);
            this.weeklyRadioButton.TabIndex = 0;
            this.weeklyRadioButton.TabStop = true;
            this.weeklyRadioButton.Text = "Weekly";
            this.weeklyRadioButton.UseVisualStyleBackColor = true;
            this.weeklyRadioButton.CheckedChanged += new System.EventHandler(this.weeklyRadioButton_CheckedChanged);
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Depth = 0;
            this.monthlyRadioButton.Location = new System.Drawing.Point(206, 178);
            this.monthlyRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.monthlyRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Ripple = true;
            this.monthlyRadioButton.Size = new System.Drawing.Size(93, 37);
            this.monthlyRadioButton.TabIndex = 1;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            this.monthlyRadioButton.CheckedChanged += new System.EventHandler(this.monthlyRadioButton_CheckedChanged);
            // 
            // statisticsChart
            // 
            chartArea1.Name = "MainArea";
            this.statisticsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statisticsChart.Legends.Add(legend1);
            this.statisticsChart.Location = new System.Drawing.Point(46, 267);
            this.statisticsChart.Name = "statisticsChart";
            this.statisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "MainArea";
            series1.Legend = "Legend1";
            series1.Name = "Project Time";
            this.statisticsChart.Series.Add(series1);
            this.statisticsChart.Size = new System.Drawing.Size(749, 384);
            this.statisticsChart.TabIndex = 2;
            this.statisticsChart.Text = "chart1";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 690);
            this.Controls.Add(this.statisticsChart);
            this.Controls.Add(this.monthlyRadioButton);
            this.Controls.Add(this.weeklyRadioButton);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton weeklyRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton monthlyRadioButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
    }
}