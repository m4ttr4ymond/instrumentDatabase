namespace Instrument_Database_Test
{
    partial class CheckoutsPerStudent
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.checkoutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentListLabel = new System.Windows.Forms.Label();
            this.studentList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutChart)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutChart
            // 
            chartArea2.Name = "ChartArea1";
            this.checkoutChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.checkoutChart.Legends.Add(legend2);
            this.checkoutChart.Location = new System.Drawing.Point(13, 13);
            this.checkoutChart.Name = "checkoutChart";
            this.checkoutChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.checkoutChart.Size = new System.Drawing.Size(968, 750);
            this.checkoutChart.TabIndex = 0;
            this.checkoutChart.Text = "chart1";
            // 
            // studentListLabel
            // 
            this.studentListLabel.AutoSize = true;
            this.studentListLabel.Location = new System.Drawing.Point(673, 217);
            this.studentListLabel.Name = "studentListLabel";
            this.studentListLabel.Size = new System.Drawing.Size(97, 25);
            this.studentListLabel.TabIndex = 2;
            this.studentListLabel.Text = "Students";
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 25;
            this.studentList.Location = new System.Drawing.Point(678, 245);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(202, 404);
            this.studentList.TabIndex = 1;
            this.studentList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentList_MouseDoubleClick);
            // 
            // CheckoutsPerStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 770);
            this.Controls.Add(this.studentListLabel);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.checkoutChart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1012, 841);
            this.MinimumSize = new System.Drawing.Size(1012, 841);
            this.Name = "CheckoutsPerStudent";
            this.Text = "CheckoutsPerStudent";
            ((System.ComponentModel.ISupportInitialize)(this.checkoutChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart checkoutChart;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Label studentListLabel;
        //private System.Windows.Forms.ListView studentList;
    }
}