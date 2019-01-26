namespace Instrument_Database_Test
{
    partial class employeeSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeSelect));
            this.employeeBox = new System.Windows.Forms.ListBox();
            this.selectItem = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeBox
            // 
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.ItemHeight = 25;
            this.employeeBox.Location = new System.Drawing.Point(13, 13);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(207, 229);
            this.employeeBox.TabIndex = 0;
            this.employeeBox.DoubleClick += new System.EventHandler(this.selectItem_Click);
            // 
            // selectItem
            // 
            this.selectItem.Location = new System.Drawing.Point(37, 248);
            this.selectItem.Name = "selectItem";
            this.selectItem.Size = new System.Drawing.Size(164, 49);
            this.selectItem.TabIndex = 1;
            this.selectItem.Text = "Select";
            this.selectItem.UseVisualStyleBackColor = true;
            this.selectItem.Click += new System.EventHandler(this.selectItem_Click);
            // 
            // otherButton
            // 
            this.otherButton.Location = new System.Drawing.Point(37, 303);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(164, 49);
            this.otherButton.TabIndex = 2;
            this.otherButton.Text = "Other User";
            this.otherButton.UseVisualStyleBackColor = true;
            this.otherButton.Click += new System.EventHandler(this.otherButton_Click);
            // 
            // employeeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 372);
            this.Controls.Add(this.otherButton);
            this.Controls.Add(this.selectItem);
            this.Controls.Add(this.employeeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(258, 443);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(258, 443);
            this.Name = "employeeSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.employeeSelect_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeeBox;
        private System.Windows.Forms.Button selectItem;
        private System.Windows.Forms.Button otherButton;
    }
}