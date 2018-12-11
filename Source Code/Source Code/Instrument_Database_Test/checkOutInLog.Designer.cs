namespace Instrument_Database_Test
{
    partial class checkOutInLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkOutInLog));
            this.checkLogDisplay = new System.Windows.Forms.Label();
            this.checkoutGrid = new System.Windows.Forms.DataGridView();
            this.checkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // checkLogDisplay
            // 
            this.checkLogDisplay.AutoSize = true;
            this.checkLogDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLogDisplay.Location = new System.Drawing.Point(13, 13);
            this.checkLogDisplay.Name = "checkLogDisplay";
            this.checkLogDisplay.Size = new System.Drawing.Size(116, 25);
            this.checkLogDisplay.TabIndex = 0;
            this.checkLogDisplay.Text = "Log Label";
            // 
            // checkoutGrid
            // 
            this.checkoutGrid.AllowUserToAddRows = false;
            this.checkoutGrid.AllowUserToDeleteRows = false;
            this.checkoutGrid.AllowUserToOrderColumns = true;
            this.checkoutGrid.AllowUserToResizeColumns = false;
            this.checkoutGrid.AllowUserToResizeRows = false;
            this.checkoutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkoutGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkType,
            this.sName,
            this.sID,
            this.sEmail,
            this.date,
            this.staff,
            this.semester,
            this.notes});
            this.checkoutGrid.Location = new System.Drawing.Point(18, 41);
            this.checkoutGrid.MultiSelect = false;
            this.checkoutGrid.Name = "checkoutGrid";
            this.checkoutGrid.ReadOnly = true;
            this.checkoutGrid.RowTemplate.Height = 33;
            this.checkoutGrid.Size = new System.Drawing.Size(908, 410);
            this.checkoutGrid.TabIndex = 0;
            this.checkoutGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkoutGrid_CellContentClick);
            this.checkoutGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.content_DoubleClick);
            this.checkoutGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkoutGrid_CellEndEdit);
            // 
            // checkType
            // 
            this.checkType.HeaderText = "In/Out";
            this.checkType.Name = "checkType";
            this.checkType.ReadOnly = true;
            this.checkType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.checkType.ToolTipText = "Double-click to flip the checking type (i.e. check in to check out)";
            this.checkType.Width = 75;
            // 
            // sName
            // 
            this.sName.HeaderText = "Name";
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
            this.sName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sName.ToolTipText = "Double-click the desired cell to edit text";
            this.sName.Width = 125;
            // 
            // sID
            // 
            this.sID.HeaderText = "ID #";
            this.sID.Name = "sID";
            this.sID.ReadOnly = true;
            this.sID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sID.ToolTipText = "Double-click the desired cell to edit text";
            // 
            // sEmail
            // 
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.ReadOnly = true;
            this.sEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sEmail.ToolTipText = "Double-click the desired cell to edit text";
            this.sEmail.Width = 200;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.ToolTipText = "Double-click the desired cell to edit text";
            this.date.Width = 75;
            // 
            // staff
            // 
            this.staff.HeaderText = "Staff";
            this.staff.Name = "staff";
            this.staff.ReadOnly = true;
            this.staff.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.staff.ToolTipText = "Double-click the desired cell to edit text";
            this.staff.Width = 125;
            // 
            // semester
            // 
            this.semester.HeaderText = "Semester";
            this.semester.Name = "semester";
            this.semester.ReadOnly = true;
            this.semester.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.semester.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.semester.ToolTipText = "Double-click the desired cell to edit text";
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.notes.ToolTipText = "Double-click to bring up a note editor";
            this.notes.Width = 50;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(379, 458);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 41);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // checkOutInLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 479);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkoutGrid);
            this.Controls.Add(this.checkLogDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "checkOutInLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check In/Out Log";
            this.Activated += new System.EventHandler(this.checkOutInLog_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.checkOutInLog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.checkoutGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkLogDisplay;
        private System.Windows.Forms.DataGridView checkoutGrid;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}