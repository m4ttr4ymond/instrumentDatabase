namespace Instrument_Database_Test
{
    partial class DataDisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataDisplay));
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dayLabel = new System.Windows.Forms.Label();
            this.rankingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentListLabel = new System.Windows.Forms.Label();
            this.studentList = new System.Windows.Forms.ListBox();
            this.RankingPanel = new System.Windows.Forms.Panel();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.instrumentTitle = new System.Windows.Forms.Label();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.RadioButton();
            this.InstrumentRadio = new System.Windows.Forms.RadioButton();
            this.employeeRadio = new System.Windows.Forms.RadioButton();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.startCalendar = new System.Windows.Forms.MonthCalendar();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.studentPanel.SuspendLayout();
            this.RankingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(-1, -1);
            this.barChart.Name = "barChart";
            this.barChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.barChart.Size = new System.Drawing.Size(1069, 485);
            this.barChart.TabIndex = 0;
            this.barChart.Text = "Visits Throughout the Week";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayLabel.Location = new System.Drawing.Point(3, 10);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(72, 27);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.Text = "label1";
            // 
            // rankingLabel
            // 
            this.rankingLabel.AutoSize = true;
            this.rankingLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankingLabel.Location = new System.Drawing.Point(3, 268);
            this.rankingLabel.Name = "rankingLabel";
            this.rankingLabel.Size = new System.Drawing.Size(72, 27);
            this.rankingLabel.TabIndex = 0;
            this.rankingLabel.Text = "label1";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1610, 994);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 50);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.studentListLabel);
            this.studentPanel.Controls.Add(this.studentList);
            this.studentPanel.Location = new System.Drawing.Point(1224, 549);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(218, 450);
            this.studentPanel.TabIndex = 0;
            this.studentPanel.Visible = false;
            // 
            // studentListLabel
            // 
            this.studentListLabel.AutoSize = true;
            this.studentListLabel.Location = new System.Drawing.Point(3, 10);
            this.studentListLabel.Name = "studentListLabel";
            this.studentListLabel.Size = new System.Drawing.Size(97, 25);
            this.studentListLabel.TabIndex = 2;
            this.studentListLabel.Text = "Students";
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 25;
            this.studentList.Location = new System.Drawing.Point(8, 38);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(202, 404);
            this.studentList.TabIndex = 1;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_ClickStudent);
            // 
            // RankingPanel
            // 
            this.RankingPanel.Controls.Add(this.dayLabel);
            this.RankingPanel.Controls.Add(this.rankingLabel);
            this.RankingPanel.Location = new System.Drawing.Point(1080, 19);
            this.RankingPanel.Name = "RankingPanel";
            this.RankingPanel.Size = new System.Drawing.Size(200, 524);
            this.RankingPanel.TabIndex = 0;
            this.RankingPanel.Visible = false;
            // 
            // lineChart
            // 
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.lineChart.Legends.Add(legend2);
            this.lineChart.Location = new System.Drawing.Point(-1, 559);
            this.lineChart.Name = "lineChart";
            this.lineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.lineChart.Size = new System.Drawing.Size(1069, 485);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "Visits Throughout the Week";
            // 
            // instrumentTitle
            // 
            this.instrumentTitle.AutoSize = true;
            this.instrumentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentTitle.Location = new System.Drawing.Point(370, 547);
            this.instrumentTitle.Name = "instrumentTitle";
            this.instrumentTitle.Size = new System.Drawing.Size(100, 37);
            this.instrumentTitle.TabIndex = 0;
            this.instrumentTitle.Text = "label1";
            this.instrumentTitle.Visible = false;
            // 
            // optionPanel
            // 
            this.optionPanel.Controls.Add(this.Time);
            this.optionPanel.Controls.Add(this.InstrumentRadio);
            this.optionPanel.Controls.Add(this.employeeRadio);
            this.optionPanel.Controls.Add(this.studentRadio);
            this.optionPanel.Location = new System.Drawing.Point(1133, 640);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(202, 148);
            this.optionPanel.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(4, 109);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(90, 29);
            this.Time.TabIndex = 0;
            this.Time.TabStop = true;
            this.Time.Text = "Time";
            this.Time.UseVisualStyleBackColor = true;
            this.Time.Visible = false;
            // 
            // InstrumentRadio
            // 
            this.InstrumentRadio.AutoSize = true;
            this.InstrumentRadio.Location = new System.Drawing.Point(4, 74);
            this.InstrumentRadio.Name = "InstrumentRadio";
            this.InstrumentRadio.Size = new System.Drawing.Size(143, 29);
            this.InstrumentRadio.TabIndex = 4;
            this.InstrumentRadio.TabStop = true;
            this.InstrumentRadio.Text = "Instrument";
            this.InstrumentRadio.UseVisualStyleBackColor = true;
            this.InstrumentRadio.Click += new System.EventHandler(this.InstrumentRadio_CheckedChanged);
            // 
            // employeeRadio
            // 
            this.employeeRadio.AutoSize = true;
            this.employeeRadio.Location = new System.Drawing.Point(4, 39);
            this.employeeRadio.Name = "employeeRadio";
            this.employeeRadio.Size = new System.Drawing.Size(138, 29);
            this.employeeRadio.TabIndex = 3;
            this.employeeRadio.TabStop = true;
            this.employeeRadio.Text = "Employee";
            this.employeeRadio.UseVisualStyleBackColor = true;
            this.employeeRadio.Click += new System.EventHandler(this.employeeRadio_CheckedChanged);
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Location = new System.Drawing.Point(4, 4);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(117, 29);
            this.studentRadio.TabIndex = 2;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Student";
            this.studentRadio.UseVisualStyleBackColor = true;
            this.studentRadio.Click += new System.EventHandler(this.studentRadio_CheckedChanged);
            // 
            // startCalendar
            // 
            this.startCalendar.Location = new System.Drawing.Point(1334, 53);
            this.startCalendar.MaxSelectionCount = 1;
            this.startCalendar.Name = "startCalendar";
            this.startCalendar.TabIndex = 5;
            this.startCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.startCalendar_DateChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(1334, 19);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(108, 25);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start Date";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(1334, 377);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(101, 25);
            this.endLabel.TabIndex = 0;
            this.endLabel.Text = "End Date";
            // 
            // endCalendar
            // 
            this.endCalendar.Location = new System.Drawing.Point(1334, 411);
            this.endCalendar.MaxSelectionCount = 1;
            this.endCalendar.Name = "endCalendar";
            this.endCalendar.TabIndex = 6;
            this.endCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.endCalendar_DateChanged);
            // 
            // DataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1818, 1069);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.endCalendar);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startCalendar);
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.instrumentTitle);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.RankingPanel);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.barChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MostPopularDay";
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.RankingPanel.ResumeLayout(false);
            this.RankingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label rankingLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Label studentListLabel;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Panel RankingPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Label instrumentTitle;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.RadioButton Time;
        private System.Windows.Forms.RadioButton InstrumentRadio;
        private System.Windows.Forms.RadioButton employeeRadio;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.MonthCalendar startCalendar;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.MonthCalendar endCalendar;
    }
}