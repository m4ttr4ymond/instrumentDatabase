using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform for filling out instrument information
    public partial class Data_Form : Form
    {
        public Data_Form()
        {
            InitializeComponent();

            // List of catagories
            BindingList<Instrument.Catagory> catagories =
                new BindingList<Instrument.Catagory> { (Instrument.Catagory) 0, // Brass
                                                       (Instrument.Catagory) 1, // Percussion
                                                       (Instrument.Catagory) 2, // Strings
                                                       (Instrument.Catagory) 3, // Woodwinds
                                                       (Instrument.Catagory) 4, // EMA
                                                       (Instrument.Catagory) 5, // Microphone
                                                       (Instrument.Catagory) 6, // Mute
                                                       (Instrument.Catagory) 7}; // Other
            
            // Populate catagoryBox
            catagoryBox.DataSource = catagories;
            catagoryBox.Select();
            errorLabel.Text = "";
            nameBox.Select();
            Refresh();
        }

        // Save information to file
        private void saveNewButton_Click(object sender, EventArgs e)
        {
            int cabinate = 0;
            int value = 0;

            if (nameBox.Text != "" & idBox.Text != "")
            {
                // Checks to make sure that the user entered numbers where necessary
                if (Int32.TryParse(cabinateBox.Text, out cabinate) && Int32.TryParse(valueBox.Text, out value))
                {
                    // If the bow box is empty (skipped), fill with N/A
                    switch (bowBox.Text)
                    {
                        case "":
                            bowBox.Text = "N/A";
                            break;
                    }

                    // Create new instrument
                    Instrument temp = new Instrument((Instrument.Catagory)catagoryBox.SelectedIndex, cabinate,
                                                    nameBox.Text, idBox.Text, bowBox.Text, brandBox.Text, modelBox.Text, vendorBox.Text,
                                                    serialNumBox.Text, Int32.Parse(valueBox.Text), noteBox.Text);

                    // Add instrument to allInstruments
                    Form1.allInstruments.Add(temp);
                    // Send to the appropriate catagory list
                    Form1.typeSwitch(temp);
                    Close();
                }
                else errorLabel.Text = "You need to enter your number\nvalues as integers.";
            }
            else errorLabel.Text = "You are missing either the\ninstrument name or ID.";
            
        }

        // Cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Autofill's the bow id textbox if there's nothing in it
        private void bowBox_Leave(object sender, EventArgs e)
        {
            if (bowBox.Text == "" || bowBox.Text.ToLower() == "n/a")
                bowBox.Text = "N/A";
        }

        // Autofill N/A if instrument doesn't usually have one
        private void catagoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catagoryBox.SelectedItem.ToString() != "Strings")
                bowBox.Text = "N/A";
            else if (bowBox.Text.ToLower() == "n/a")
                bowBox.Text = "";
        }
    }
}
