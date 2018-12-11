namespace Instrument_Database_Test
{
    partial class Data_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Form));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cabinateBox = new System.Windows.Forms.TextBox();
            this.cabinateLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.bowBox = new System.Windows.Forms.TextBox();
            this.bowLabel = new System.Windows.Forms.Label();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.vendorBox = new System.Windows.Forms.TextBox();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.serialNumBox = new System.Windows.Forms.TextBox();
            this.serialNumLabel = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.catagoryLabel = new System.Windows.Forms.Label();
            this.catagoryBox = new System.Windows.Forms.ListBox();
            this.saveNewButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(56, 82);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(170, 31);
            this.nameBox.TabIndex = 0;
            // 
            // cabinateBox
            // 
            this.cabinateBox.Location = new System.Drawing.Point(56, 189);
            this.cabinateBox.Name = "cabinateBox";
            this.cabinateBox.Size = new System.Drawing.Size(170, 31);
            this.cabinateBox.TabIndex = 1;
            // 
            // cabinateLabel
            // 
            this.cabinateLabel.AutoSize = true;
            this.cabinateLabel.Location = new System.Drawing.Point(51, 143);
            this.cabinateLabel.Name = "cabinateLabel";
            this.cabinateLabel.Size = new System.Drawing.Size(98, 25);
            this.cabinateLabel.TabIndex = 2;
            this.cabinateLabel.Text = "Cabinate";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(56, 301);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(170, 31);
            this.idBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(51, 255);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(138, 25);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Instrument ID";
            // 
            // bowBox
            // 
            this.bowBox.Location = new System.Drawing.Point(56, 407);
            this.bowBox.Name = "bowBox";
            this.bowBox.Size = new System.Drawing.Size(170, 31);
            this.bowBox.TabIndex = 3;
            this.bowBox.Leave += new System.EventHandler(this.bowBox_Leave);
            // 
            // bowLabel
            // 
            this.bowLabel.AutoSize = true;
            this.bowLabel.Location = new System.Drawing.Point(51, 361);
            this.bowLabel.Name = "bowLabel";
            this.bowLabel.Size = new System.Drawing.Size(53, 25);
            this.bowLabel.TabIndex = 6;
            this.bowLabel.Text = "Bow";
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(290, 82);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(170, 31);
            this.brandBox.TabIndex = 4;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(285, 36);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(69, 25);
            this.brandLabel.TabIndex = 8;
            this.brandLabel.Text = "Brand";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(290, 189);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(170, 31);
            this.modelBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(285, 143);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(71, 25);
            this.modelLabel.TabIndex = 10;
            this.modelLabel.Text = "Model";
            // 
            // vendorBox
            // 
            this.vendorBox.Location = new System.Drawing.Point(290, 301);
            this.vendorBox.Name = "vendorBox";
            this.vendorBox.Size = new System.Drawing.Size(170, 31);
            this.vendorBox.TabIndex = 6;
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Location = new System.Drawing.Point(285, 255);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(81, 25);
            this.vendorLabel.TabIndex = 12;
            this.vendorLabel.Text = "Vendor";
            // 
            // serialNumBox
            // 
            this.serialNumBox.Location = new System.Drawing.Point(290, 407);
            this.serialNumBox.Name = "serialNumBox";
            this.serialNumBox.Size = new System.Drawing.Size(170, 31);
            this.serialNumBox.TabIndex = 7;
            // 
            // serialNumLabel
            // 
            this.serialNumLabel.AutoSize = true;
            this.serialNumLabel.Location = new System.Drawing.Point(285, 361);
            this.serialNumLabel.Name = "serialNumLabel";
            this.serialNumLabel.Size = new System.Drawing.Size(148, 25);
            this.serialNumLabel.TabIndex = 14;
            this.serialNumLabel.Text = "Serial Number";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(512, 82);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(170, 31);
            this.valueBox.TabIndex = 8;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(507, 36);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(67, 25);
            this.valueLabel.TabIndex = 16;
            this.valueLabel.Text = "Value";
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(512, 189);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(170, 31);
            this.noteBox.TabIndex = 9;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(507, 143);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(68, 25);
            this.noteLabel.TabIndex = 18;
            this.noteLabel.Text = "Notes";
            // 
            // catagoryLabel
            // 
            this.catagoryLabel.AutoSize = true;
            this.catagoryLabel.Location = new System.Drawing.Point(507, 255);
            this.catagoryLabel.Name = "catagoryLabel";
            this.catagoryLabel.Size = new System.Drawing.Size(99, 25);
            this.catagoryLabel.TabIndex = 20;
            this.catagoryLabel.Text = "Catagory";
            // 
            // catagoryBox
            // 
            this.catagoryBox.FormattingEnabled = true;
            this.catagoryBox.ItemHeight = 25;
            this.catagoryBox.Location = new System.Drawing.Point(512, 301);
            this.catagoryBox.Name = "catagoryBox";
            this.catagoryBox.Size = new System.Drawing.Size(170, 179);
            this.catagoryBox.TabIndex = 10;
            this.catagoryBox.SelectedIndexChanged += new System.EventHandler(this.catagoryBox_SelectedIndexChanged);
            // 
            // saveNewButton
            // 
            this.saveNewButton.Location = new System.Drawing.Point(474, 496);
            this.saveNewButton.Name = "saveNewButton";
            this.saveNewButton.Size = new System.Drawing.Size(122, 42);
            this.saveNewButton.TabIndex = 11;
            this.saveNewButton.Text = "Save";
            this.saveNewButton.UseVisualStyleBackColor = true;
            this.saveNewButton.Click += new System.EventHandler(this.saveNewButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(602, 496);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 42);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(56, 466);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(70, 25);
            this.errorLabel.TabIndex = 24;
            this.errorLabel.Text = "label1";
            // 
            // Data_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 570);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveNewButton);
            this.Controls.Add(this.catagoryBox);
            this.Controls.Add(this.catagoryLabel);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.serialNumBox);
            this.Controls.Add(this.serialNumLabel);
            this.Controls.Add(this.vendorBox);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.bowBox);
            this.Controls.Add(this.bowLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cabinateBox);
            this.Controls.Add(this.cabinateLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(814, 641);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(814, 641);
            this.Name = "Data_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Instrument Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox cabinateBox;
        private System.Windows.Forms.Label cabinateLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox bowBox;
        private System.Windows.Forms.Label bowLabel;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox vendorBox;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.TextBox serialNumBox;
        private System.Windows.Forms.Label serialNumLabel;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label catagoryLabel;
        private System.Windows.Forms.ListBox catagoryBox;
        private System.Windows.Forms.Button saveNewButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorLabel;
    }
}