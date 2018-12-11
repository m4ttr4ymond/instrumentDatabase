namespace Instrument_Database_Test
{
    partial class Form1
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
            System.Windows.Forms.Button percussionButton;
            System.Windows.Forms.Button stringsButton;
            System.Windows.Forms.Button woodwindsButton;
            System.Windows.Forms.Button emaButton;
            System.Windows.Forms.Button microphoneButton;
            System.Windows.Forms.Button muteButton;
            System.Windows.Forms.Button otherButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instrumentList = new System.Windows.Forms.ListBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.allInstrumentsButton = new System.Windows.Forms.Button();
            this.brassButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.cancelBox = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.checkLogButton = new System.Windows.Forms.Button();
            this.missingButton = new System.Windows.Forms.Button();
            this.csvExportButton = new System.Windows.Forms.Button();
            this.addEmployeesButton = new System.Windows.Forms.Button();
            this.changeEmployeeButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.checkoutsPerStudent = new System.Windows.Forms.Button();
            this.newDataDisplay = new System.Windows.Forms.RichTextBox();
            percussionButton = new System.Windows.Forms.Button();
            stringsButton = new System.Windows.Forms.Button();
            woodwindsButton = new System.Windows.Forms.Button();
            emaButton = new System.Windows.Forms.Button();
            microphoneButton = new System.Windows.Forms.Button();
            muteButton = new System.Windows.Forms.Button();
            otherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // percussionButton
            // 
            percussionButton.Location = new System.Drawing.Point(309, 193);
            percussionButton.Name = "percussionButton";
            percussionButton.Size = new System.Drawing.Size(181, 49);
            percussionButton.TabIndex = 5;
            percussionButton.Text = "Percussion";
            percussionButton.UseVisualStyleBackColor = true;
            percussionButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // stringsButton
            // 
            stringsButton.Location = new System.Drawing.Point(309, 248);
            stringsButton.Name = "stringsButton";
            stringsButton.Size = new System.Drawing.Size(181, 49);
            stringsButton.TabIndex = 6;
            stringsButton.Text = "Strings";
            stringsButton.UseVisualStyleBackColor = true;
            stringsButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // woodwindsButton
            // 
            woodwindsButton.Location = new System.Drawing.Point(309, 303);
            woodwindsButton.Name = "woodwindsButton";
            woodwindsButton.Size = new System.Drawing.Size(181, 49);
            woodwindsButton.TabIndex = 7;
            woodwindsButton.Text = "Woodwinds";
            woodwindsButton.UseVisualStyleBackColor = true;
            woodwindsButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // emaButton
            // 
            emaButton.Location = new System.Drawing.Point(309, 358);
            emaButton.Name = "emaButton";
            emaButton.Size = new System.Drawing.Size(181, 49);
            emaButton.TabIndex = 8;
            emaButton.Text = "EMA";
            emaButton.UseVisualStyleBackColor = true;
            emaButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // microphoneButton
            // 
            microphoneButton.Location = new System.Drawing.Point(309, 413);
            microphoneButton.Name = "microphoneButton";
            microphoneButton.Size = new System.Drawing.Size(181, 49);
            microphoneButton.TabIndex = 9;
            microphoneButton.Text = "Microphone";
            microphoneButton.UseVisualStyleBackColor = true;
            microphoneButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // muteButton
            // 
            muteButton.Location = new System.Drawing.Point(309, 468);
            muteButton.Name = "muteButton";
            muteButton.Size = new System.Drawing.Size(181, 49);
            muteButton.TabIndex = 10;
            muteButton.Text = "Mutes";
            muteButton.UseVisualStyleBackColor = true;
            muteButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // otherButton
            // 
            otherButton.Location = new System.Drawing.Point(309, 523);
            otherButton.Name = "otherButton";
            otherButton.Size = new System.Drawing.Size(181, 49);
            otherButton.TabIndex = 11;
            otherButton.Text = "Other";
            otherButton.UseVisualStyleBackColor = true;
            otherButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // instrumentList
            // 
            this.instrumentList.FormattingEnabled = true;
            this.instrumentList.ItemHeight = 25;
            this.instrumentList.Location = new System.Drawing.Point(17, 83);
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.Size = new System.Drawing.Size(286, 479);
            this.instrumentList.TabIndex = 12;
            this.instrumentList.SelectedIndexChanged += new System.EventHandler(this.instrumentList_SelectedIndexChanged);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(517, 83);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(101, 25);
            this.dataLabel.TabIndex = 25;
            this.dataLabel.Text = "Overview";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(204, 580);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(181, 63);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(681, 649);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(181, 63);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // allInstrumentsButton
            // 
            this.allInstrumentsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.allInstrumentsButton.Location = new System.Drawing.Point(309, 83);
            this.allInstrumentsButton.Name = "allInstrumentsButton";
            this.allInstrumentsButton.Size = new System.Drawing.Size(181, 49);
            this.allInstrumentsButton.TabIndex = 3;
            this.allInstrumentsButton.Text = "All Instruments";
            this.allInstrumentsButton.UseVisualStyleBackColor = false;
            this.allInstrumentsButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // brassButton
            // 
            this.brassButton.Location = new System.Drawing.Point(309, 138);
            this.brassButton.Name = "brassButton";
            this.brassButton.Size = new System.Drawing.Size(181, 49);
            this.brassButton.TabIndex = 4;
            this.brassButton.Text = "Brass";
            this.brassButton.UseVisualStyleBackColor = true;
            this.brassButton.Click += new System.EventHandler(this.changeIndex);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(204, 649);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(181, 63);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(241, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 45);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(17, 37);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(218, 31);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(80, 25);
            this.searchLabel.TabIndex = 17;
            this.searchLabel.Text = "Search";
            // 
            // cancelBox
            // 
            this.cancelBox.Location = new System.Drawing.Point(348, 30);
            this.cancelBox.Name = "cancelBox";
            this.cancelBox.Size = new System.Drawing.Size(101, 45);
            this.cancelBox.TabIndex = 2;
            this.cancelBox.Text = "Cancel";
            this.cancelBox.UseVisualStyleBackColor = true;
            this.cancelBox.Click += new System.EventHandler(this.cancelBox_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(17, 580);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(181, 63);
            this.checkoutButton.TabIndex = 12;
            this.checkoutButton.Text = "Check Out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(17, 649);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(181, 63);
            this.checkInButton.TabIndex = 13;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // checkLogButton
            // 
            this.checkLogButton.Location = new System.Drawing.Point(784, 30);
            this.checkLogButton.Name = "checkLogButton";
            this.checkLogButton.Size = new System.Drawing.Size(218, 45);
            this.checkLogButton.TabIndex = 18;
            this.checkLogButton.Text = "Check In/Out Log";
            this.checkLogButton.UseVisualStyleBackColor = true;
            this.checkLogButton.Click += new System.EventHandler(this.checkLogButton_Click);
            // 
            // missingButton
            // 
            this.missingButton.Location = new System.Drawing.Point(391, 649);
            this.missingButton.Name = "missingButton";
            this.missingButton.Size = new System.Drawing.Size(181, 63);
            this.missingButton.TabIndex = 16;
            this.missingButton.Text = "Missing Status";
            this.missingButton.UseVisualStyleBackColor = true;
            this.missingButton.Click += new System.EventHandler(this.missingButton_Click);
            // 
            // csvExportButton
            // 
            this.csvExportButton.Location = new System.Drawing.Point(784, 85);
            this.csvExportButton.Name = "csvExportButton";
            this.csvExportButton.Size = new System.Drawing.Size(218, 45);
            this.csvExportButton.TabIndex = 19;
            this.csvExportButton.Text = "Export .csv File";
            this.csvExportButton.UseVisualStyleBackColor = true;
            this.csvExportButton.Click += new System.EventHandler(this.csvExportButton_Click);
            // 
            // addEmployeesButton
            // 
            this.addEmployeesButton.Location = new System.Drawing.Point(784, 136);
            this.addEmployeesButton.Name = "addEmployeesButton";
            this.addEmployeesButton.Size = new System.Drawing.Size(218, 45);
            this.addEmployeesButton.TabIndex = 20;
            this.addEmployeesButton.Text = "Add Employees";
            this.addEmployeesButton.UseVisualStyleBackColor = true;
            this.addEmployeesButton.Click += new System.EventHandler(this.addEmployeesButton_Click);
            // 
            // changeEmployeeButton
            // 
            this.changeEmployeeButton.Location = new System.Drawing.Point(784, 187);
            this.changeEmployeeButton.Name = "changeEmployeeButton";
            this.changeEmployeeButton.Size = new System.Drawing.Size(218, 45);
            this.changeEmployeeButton.TabIndex = 21;
            this.changeEmployeeButton.Text = "Change Employee";
            this.changeEmployeeButton.UseVisualStyleBackColor = true;
            this.changeEmployeeButton.Click += new System.EventHandler(this.changeEmployeeButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(784, 289);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(218, 45);
            this.importButton.TabIndex = 23;
            this.importButton.Text = "Import Backup";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(784, 238);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(218, 45);
            this.backupButton.TabIndex = 22;
            this.backupButton.Text = "Create Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // dataButton
            // 
            this.dataButton.Location = new System.Drawing.Point(784, 340);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(218, 45);
            this.dataButton.TabIndex = 24;
            this.dataButton.Text = "Checkout Data";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // checkoutsPerStudent
            // 
            this.checkoutsPerStudent.Location = new System.Drawing.Point(784, 391);
            this.checkoutsPerStudent.Name = "checkoutsPerStudent";
            this.checkoutsPerStudent.Size = new System.Drawing.Size(218, 45);
            this.checkoutsPerStudent.TabIndex = 25;
            this.checkoutsPerStudent.Text = "Student Data";
            this.checkoutsPerStudent.UseVisualStyleBackColor = true;
            this.checkoutsPerStudent.Click += new System.EventHandler(this.checkoutsPerStudent_Click);
            // 
            // newDataDisplay
            // 
            this.newDataDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newDataDisplay.Location = new System.Drawing.Point(522, 117);
            this.newDataDisplay.Name = "newDataDisplay";
            this.newDataDisplay.ReadOnly = true;
            this.newDataDisplay.Size = new System.Drawing.Size(234, 455);
            this.newDataDisplay.TabIndex = 28;
            this.newDataDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 724);
            this.Controls.Add(this.newDataDisplay);
            this.Controls.Add(this.checkoutsPerStudent);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.changeEmployeeButton);
            this.Controls.Add(this.addEmployeesButton);
            this.Controls.Add(this.csvExportButton);
            this.Controls.Add(this.missingButton);
            this.Controls.Add(this.checkLogButton);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.cancelBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(otherButton);
            this.Controls.Add(muteButton);
            this.Controls.Add(microphoneButton);
            this.Controls.Add(emaButton);
            this.Controls.Add(woodwindsButton);
            this.Controls.Add(stringsButton);
            this.Controls.Add(percussionButton);
            this.Controls.Add(this.brassButton);
            this.Controls.Add(this.allInstrumentsButton);
            this.Controls.Add(this.instrumentList);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrument Library Filer v 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox instrumentList;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button allInstrumentsButton;
        private System.Windows.Forms.Button brassButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button cancelBox;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button checkLogButton;
        private System.Windows.Forms.Button missingButton;
        private System.Windows.Forms.Button csvExportButton;
        private System.Windows.Forms.Button addEmployeesButton;
        private System.Windows.Forms.Button changeEmployeeButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.Button checkoutsPerStudent;
        private System.Windows.Forms.RichTextBox newDataDisplay;
    }
}

