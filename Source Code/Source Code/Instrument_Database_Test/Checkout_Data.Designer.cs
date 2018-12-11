namespace Instrument_Database_Test
{
    partial class Checkout_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout_Data));
            this.sNameLabel = new System.Windows.Forms.Label();
            this.sNameBox = new System.Windows.Forms.TextBox();
            this.sIDBox = new System.Windows.Forms.TextBox();
            this.sIDLabel = new System.Windows.Forms.Label();
            this.sEmailBox = new System.Windows.Forms.TextBox();
            this.sEmailLabel = new System.Windows.Forms.Label();
            this.staffBox = new System.Windows.Forms.TextBox();
            this.staffNameLabel = new System.Windows.Forms.Label();
            this.checkoutDate = new System.Windows.Forms.MonthCalendar();
            this.dateLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.fallButton = new System.Windows.Forms.RadioButton();
            this.intertermButton = new System.Windows.Forms.RadioButton();
            this.springButton = new System.Windows.Forms.RadioButton();
            this.summerButton = new System.Windows.Forms.RadioButton();
            this.newEmail = new System.Windows.Forms.RadioButton();
            this.oldEmail = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customEmail = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Location = new System.Drawing.Point(12, 115);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(68, 25);
            this.sNameLabel.TabIndex = 0;
            this.sNameLabel.Text = "Name";
            // 
            // sNameBox
            // 
            this.sNameBox.Location = new System.Drawing.Point(17, 144);
            this.sNameBox.Name = "sNameBox";
            this.sNameBox.Size = new System.Drawing.Size(216, 31);
            this.sNameBox.TabIndex = 1;
            // 
            // sIDBox
            // 
            this.sIDBox.Location = new System.Drawing.Point(17, 38);
            this.sIDBox.Name = "sIDBox";
            this.sIDBox.Size = new System.Drawing.Size(216, 31);
            this.sIDBox.TabIndex = 0;
            this.sIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sIDBox_KeyPress);
            this.sIDBox.Leave += new System.EventHandler(this.sIDBox_Leave);
            // 
            // sIDLabel
            // 
            this.sIDLabel.AutoSize = true;
            this.sIDLabel.Location = new System.Drawing.Point(12, 9);
            this.sIDLabel.Name = "sIDLabel";
            this.sIDLabel.Size = new System.Drawing.Size(112, 25);
            this.sIDLabel.TabIndex = 2;
            this.sIDLabel.Text = "Student ID";
            // 
            // sEmailBox
            // 
            this.sEmailBox.Location = new System.Drawing.Point(17, 252);
            this.sEmailBox.Name = "sEmailBox";
            this.sEmailBox.Size = new System.Drawing.Size(216, 31);
            this.sEmailBox.TabIndex = 2;
            // 
            // sEmailLabel
            // 
            this.sEmailLabel.AutoSize = true;
            this.sEmailLabel.Location = new System.Drawing.Point(12, 223);
            this.sEmailLabel.Name = "sEmailLabel";
            this.sEmailLabel.Size = new System.Drawing.Size(150, 25);
            this.sEmailLabel.TabIndex = 4;
            this.sEmailLabel.Text = "Email Address";
            // 
            // staffBox
            // 
            this.staffBox.Location = new System.Drawing.Point(348, 464);
            this.staffBox.Name = "staffBox";
            this.staffBox.Size = new System.Drawing.Size(267, 31);
            this.staffBox.TabIndex = 11;
            // 
            // staffNameLabel
            // 
            this.staffNameLabel.AutoSize = true;
            this.staffNameLabel.Location = new System.Drawing.Point(350, 436);
            this.staffNameLabel.Name = "staffNameLabel";
            this.staffNameLabel.Size = new System.Drawing.Size(56, 25);
            this.staffNameLabel.TabIndex = 9;
            this.staffNameLabel.Text = "Staff";
            // 
            // checkoutDate
            // 
            this.checkoutDate.Location = new System.Drawing.Point(355, 38);
            this.checkoutDate.MaxSelectionCount = 1;
            this.checkoutDate.Name = "checkoutDate";
            this.checkoutDate.TabIndex = 10;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(350, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 25);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Date";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(21, 436);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(103, 25);
            this.semesterLabel.TabIndex = 13;
            this.semesterLabel.Text = "Semester";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(675, 515);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 52);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel_Button);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(675, 445);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(134, 52);
            this.checkoutButton.TabIndex = 13;
            this.checkoutButton.Text = "Check Out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkout_Button);
            // 
            // fallButton
            // 
            this.fallButton.AutoSize = true;
            this.fallButton.Location = new System.Drawing.Point(9, 3);
            this.fallButton.Name = "fallButton";
            this.fallButton.Size = new System.Drawing.Size(78, 29);
            this.fallButton.TabIndex = 6;
            this.fallButton.TabStop = true;
            this.fallButton.Text = "Fall";
            this.fallButton.UseVisualStyleBackColor = true;
            this.fallButton.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // intertermButton
            // 
            this.intertermButton.AutoSize = true;
            this.intertermButton.Location = new System.Drawing.Point(9, 38);
            this.intertermButton.Name = "intertermButton";
            this.intertermButton.Size = new System.Drawing.Size(127, 29);
            this.intertermButton.TabIndex = 7;
            this.intertermButton.TabStop = true;
            this.intertermButton.Text = "Interterm";
            this.intertermButton.UseVisualStyleBackColor = true;
            this.intertermButton.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // springButton
            // 
            this.springButton.AutoSize = true;
            this.springButton.Location = new System.Drawing.Point(180, 3);
            this.springButton.Name = "springButton";
            this.springButton.Size = new System.Drawing.Size(105, 29);
            this.springButton.TabIndex = 8;
            this.springButton.TabStop = true;
            this.springButton.Text = "Spring";
            this.springButton.UseVisualStyleBackColor = true;
            this.springButton.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // summerButton
            // 
            this.summerButton.AutoSize = true;
            this.summerButton.Location = new System.Drawing.Point(180, 38);
            this.summerButton.Name = "summerButton";
            this.summerButton.Size = new System.Drawing.Size(122, 29);
            this.summerButton.TabIndex = 9;
            this.summerButton.TabStop = true;
            this.summerButton.Text = "Summer";
            this.summerButton.UseVisualStyleBackColor = true;
            this.summerButton.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // newEmail
            // 
            this.newEmail.AutoSize = true;
            this.newEmail.Location = new System.Drawing.Point(9, 38);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(194, 29);
            this.newEmail.TabIndex = 4;
            this.newEmail.TabStop = true;
            this.newEmail.Text = "@chapman.edu";
            this.newEmail.UseVisualStyleBackColor = true;
            // 
            // oldEmail
            // 
            this.oldEmail.AutoSize = true;
            this.oldEmail.Location = new System.Drawing.Point(9, 73);
            this.oldEmail.Name = "oldEmail";
            this.oldEmail.Size = new System.Drawing.Size(239, 29);
            this.oldEmail.TabIndex = 5;
            this.oldEmail.TabStop = true;
            this.oldEmail.Text = "@mail.chapman.edu";
            this.oldEmail.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customEmail);
            this.panel1.Controls.Add(this.oldEmail);
            this.panel1.Controls.Add(this.newEmail);
            this.panel1.Location = new System.Drawing.Point(17, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 111);
            this.panel1.TabIndex = 26;
            // 
            // customEmail
            // 
            this.customEmail.AutoSize = true;
            this.customEmail.Location = new System.Drawing.Point(9, 3);
            this.customEmail.Name = "customEmail";
            this.customEmail.Size = new System.Drawing.Size(195, 29);
            this.customEmail.TabIndex = 3;
            this.customEmail.TabStop = true;
            this.customEmail.Text = "Custom Domain";
            this.customEmail.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fallButton);
            this.panel2.Controls.Add(this.springButton);
            this.panel2.Controls.Add(this.summerButton);
            this.panel2.Controls.Add(this.intertermButton);
            this.panel2.Location = new System.Drawing.Point(26, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 87);
            this.panel2.TabIndex = 27;
            // 
            // noteButton
            // 
            this.noteButton.Location = new System.Drawing.Point(675, 374);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(137, 52);
            this.noteButton.TabIndex = 12;
            this.noteButton.Text = "Add Note";
            this.noteButton.UseVisualStyleBackColor = true;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // Checkout_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 554);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.checkoutDate);
            this.Controls.Add(this.staffBox);
            this.Controls.Add(this.staffNameLabel);
            this.Controls.Add(this.sEmailBox);
            this.Controls.Add(this.sEmailLabel);
            this.Controls.Add(this.sIDBox);
            this.Controls.Add(this.sIDLabel);
            this.Controls.Add(this.sNameBox);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 625);
            this.MinimumSize = new System.Drawing.Size(850, 625);
            this.Name = "Checkout_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.TextBox sNameBox;
        private System.Windows.Forms.TextBox sIDBox;
        private System.Windows.Forms.Label sIDLabel;
        private System.Windows.Forms.TextBox sEmailBox;
        private System.Windows.Forms.Label sEmailLabel;
        private System.Windows.Forms.TextBox staffBox;
        private System.Windows.Forms.Label staffNameLabel;
        private System.Windows.Forms.MonthCalendar checkoutDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.RadioButton fallButton;
        private System.Windows.Forms.RadioButton intertermButton;
        private System.Windows.Forms.RadioButton springButton;
        private System.Windows.Forms.RadioButton summerButton;
        private System.Windows.Forms.RadioButton newEmail;
        private System.Windows.Forms.RadioButton oldEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton customEmail;
        private System.Windows.Forms.Button noteButton;
    }
}