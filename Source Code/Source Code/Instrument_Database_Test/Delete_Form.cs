using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform for deleting an instrument
    public partial class Delete_Form : Form
    {
        // List to hold the results of the search and display them to the screen
        BindingList<Instrument> searchResults = new BindingList<Instrument>();

        // "Constructor"
        public Delete_Form()
        {
            InitializeComponent();

            // Show all on open
            searchResults = Form1.allInstruments;
            ((ListBox)deleteBox).DataSource = searchResults;
            searchBox.Select();
            Refresh();
        }
        
        // Search the database
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResults.Clear();
            // Get search criteria
            string searchText = searchBox.Text;
            searchBox.SelectAll();

            // ToDo: Remove the duplicate search code
            foreach (Instrument instrument in Form1.allInstruments)
            {
                string[] content = {instrument.bow.ToLower(),
                                instrument.brand.ToLower(),
                                instrument.id.ToLower(),
                                instrument.model.ToLower(),
                                instrument.name.ToLower(),
                                instrument.serialNumber.ToLower(),
                                instrument.vendor.ToLower(),
                                instrument.type.ToString(),
                                instrument.status.ToString().ToLower(),
                                instrument.cabinate.ToString()};

                // If an item matches the search criteria, add searchResults
                if (content.Contains(searchText.ToLower()))
                    searchResults.Add(instrument);
            }
            Refresh();
        }

        // Go back to the previous window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Delete the current instruments from record
        private void deleteButton_Click(object sender, EventArgs e)
        {
            while(deleteBox.CheckedItems.Count > 0)
            {
                foreach (Instrument item in deleteBox.CheckedItems)
                {
                    Form1.allInstruments.Remove(item);
                    break;
                }
            }
            
            // Sort instruments from allInstruments into their catagories
            Form1.sortInstruments();
            Close();
        }

        // Selects all/none
        private void allButton_Click(object sender, EventArgs e)
        {
            if (deleteBox.CheckedIndices.Count < searchResults.Count)
                select(true);
            else
                select(false);                
        }

        // Sets all deleteBox members to either checked or unchecked depending on input
        private void select(bool v)
        {
            for (int i = 0; i < searchResults.Count; i++)
                deleteBox.SetItemChecked(i, v);
        }

        // Support for barcode scanning
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                searchButton_Click(sender, e);
        }
    }
}
