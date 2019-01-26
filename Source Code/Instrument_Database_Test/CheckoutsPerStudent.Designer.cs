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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutsPerStudent));
            this.checkoutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentListLabel = new System.Windows.Forms.Label();
            this.studentList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkoutChart
            // 
            chartArea1.Name = "ChartArea1";
            this.checkoutChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.checkoutChart.Legends.Add(legend1);
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
            this.studentListLabel.Location = new System.Drawing.Point(3, 10);
            this.studentListLabel.Name = "studentListLabel";
            this.studentListLabel.Size = new System.Drawing.Size(97, 25);
            this.studentListLabel.TabIndex = 0;
            this.studentListLabel.Text = "Students";
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 25;
            this.studentList.Location = new System.Drawing.Point(8, 38);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(202, 404);
            this.studentList.TabIndex = 0;
            this.studentList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentList_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentListLabel);
            this.panel1.Controls.Add(this.studentList);
            this.panel1.Location = new System.Drawing.Point(711, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 450);
            this.panel1.TabIndex = 3;
            // 
            // CheckoutsPerStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 770);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkoutChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1012, 841);
            this.MinimumSize = new System.Drawing.Size(1012, 841);
            this.Name = "CheckoutsPerStudent";
            this.Text = "CheckoutsPerStudent";
            ((System.ComponentModel.ISupportInitialize)(this.checkoutChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart checkoutChart;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Label studentListLabel;
        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.ListView studentList;
    }
}