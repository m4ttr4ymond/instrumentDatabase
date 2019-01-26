namespace Instrument_Database_Test
{
    partial class employeeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeAdd));
            this.employeeBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.RadioButton();
            this.standardButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // employeeBox
            // 
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.ItemHeight = 25;
            this.employeeBox.Location = new System.Drawing.Point(17, 118);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(246, 129);
            this.employeeBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(109, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Full Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(17, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(246, 31);
            this.nameBox.TabIndex = 1;
            this.nameBox.Click += new System.EventHandler(this.nameBox_Click);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(269, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 49);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(269, 93);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 49);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(269, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 49);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(269, 148);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 49);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.AutoSize = true;
            this.adminButton.Location = new System.Drawing.Point(17, 76);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(103, 29);
            this.adminButton.TabIndex = 2;
            this.adminButton.TabStop = true;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // standardButton
            // 
            this.standardButton.AutoSize = true;
            this.standardButton.Location = new System.Drawing.Point(126, 76);
            this.standardButton.Name = "standardButton";
            this.standardButton.Size = new System.Drawing.Size(130, 29);
            this.standardButton.TabIndex = 3;
            this.standardButton.TabStop = true;
            this.standardButton.Text = "Standard";
            this.standardButton.UseVisualStyleBackColor = true;
            // 
            // employeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 268);
            this.Controls.Add(this.standardButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.employeeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 339);
            this.Name = "employeeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Employees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.employeeAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeBox;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton adminButton;
        private System.Windows.Forms.RadioButton standardButton;
    }
}