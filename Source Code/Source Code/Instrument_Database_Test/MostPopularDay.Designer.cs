namespace Instrument_Database_Test
{
    partial class MostPopularDay
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
            this.dayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dayLabel = new System.Windows.Forms.Label();
            this.rankingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dayChart
            // 
            chartArea1.Name = "ChartArea1";
            this.dayChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dayChart.Legends.Add(legend1);
            this.dayChart.Location = new System.Drawing.Point(-1, -1);
            this.dayChart.Name = "dayChart";
            this.dayChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.dayChart.Size = new System.Drawing.Size(1069, 761);
            this.dayChart.TabIndex = 0;
            this.dayChart.Text = "Visits Throughout the Week";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayLabel.Location = new System.Drawing.Point(859, 138);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(72, 27);
            this.dayLabel.TabIndex = 1;
            this.dayLabel.Text = "label1";
            // 
            // rankingLabel
            // 
            this.rankingLabel.AutoSize = true;
            this.rankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankingLabel.Location = new System.Drawing.Point(859, 437);
            this.rankingLabel.Name = "rankingLabel";
            this.rankingLabel.Size = new System.Drawing.Size(72, 27);
            this.rankingLabel.TabIndex = 2;
            this.rankingLabel.Text = "label1";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(930, 698);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 50);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MostPopularDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 749);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rankingLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dayChart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1094, 820);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1094, 820);
            this.Name = "MostPopularDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MostPopularDay";
            ((System.ComponentModel.ISupportInitialize)(this.dayChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dayChart;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label rankingLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}