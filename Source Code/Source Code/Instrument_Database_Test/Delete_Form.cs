using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform for deleting an instrument
    public partial class Delete_Form : Form
    {
        Button lastSelected;

        // List to hold the results of the search and display them to the screen
        BindingList<Instrument> searchResults = new BindingList<Instrument>();

        // "Constructor"
        public Delete_Form()
        {
            InitializeComponent();

            // Show all on open
            foreach (Instrument instrument in Form1.allInstruments)
            {
                searchResults.Add(instrument);
            }
            //searchResults = Form1.allInstruments;
            ((ListBox)deleteBox).DataSource = searchResults;
            searchBox.Select();
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
            if(deleteBox.CheckedItems.Count > 0)
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

        // Search function for scanner
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If it's enter
            if (e.KeyChar == (char)13)
                searchButton_Click(sender, e);
            // Backspace key
            else if (e.KeyChar == (char)8)
                searching("", true);
            else
                searching(e.KeyChar.ToString());
        }

        // Searches through the content for a specific instrument
        private void searchButton_Click(object sender, EventArgs e)
        {
            searching();
            //searchBox.SelectAll();
        }

        // Search function for this box
        private void searching(string newChar = "", bool deleting = false)
        {
            // Array to hold the search criteria
            string[] searchCriteria;
            searchResults.Clear();

            // Select text
            string searchText = (searchBox.Text + newChar).ToLower();

            // Makes sure that the typing keeps up with the live search function
            if (deleting && searchText.Length > 0)
                searchText = searchText.Substring(0, (searchText.Length - 1));

            // Split into seperate search criteria
            searchText = searchText.Replace(", ", ",");
            searchCriteria = searchText.Split(',');

            foreach (Instrument instrument in Form1.allInstruments)
            {
                // array containing all of the content in the current instrument
                string[] content = {instrument.bow.ToLower(),
                                instrument.brand.ToLower(),
                                instrument.id.ToLower(),
                                instrument.model.ToLower(),
                                instrument.name.ToLower(),
                                instrument.serialNumber.ToLower(),
                                instrument.vendor.ToLower(),
                                instrument.type.ToString(),
                                instrument.status.ToString().ToLower(),
                                instrument.cabinate.ToString(),
                                instrument.bow.ToString().ToLower()};
                // return search result if matches
                foreach (string item in searchCriteria)
                {
                    // If not working with the and operator
                    if (!item.Contains('+'))
                    {
                        // Contains one of the criteria
                        if (containsOne(item, instrument, content))
                            searchResults.Add(instrument);
                    }
                    else
                    {
                        // Contains all of the criteria
                        if (containsAll(item, instrument, content))
                            searchResults.Add(instrument);
                    }
                }
            }
            // Refresh datasource
            deleteBox.DataSource = searchResults;
            if (deleteBox.SelectedIndex >= 0)
                deleteBox.SetSelected(deleteBox.SelectedIndex, true);
            Refresh();
        }

        // Searching with a single string
        private bool containsOne(string searchCriteria, Instrument instrument, string[] content)
        {
            // If the instrument is not in search results, cycle through and find it
            if (!searchResults.Contains(instrument))
                foreach (string item in content)
                    if (item.Contains(searchCriteria))
                        return true;
            return false;
        }

        // Searching with multiple criteria
        private bool containsAll(string searchSource, Instrument instrument, string[] content)
        {
            // Search criteria
            string[] searchCriteria = searchSource.Split('+');

            // Array that holds a boolean for each item in the search criteia
            bool[] searchLength = new bool[searchCriteria.Length];

            // Searches to make see if each item has everything that's in the search crite
            for (int i = 0; i < searchCriteria.Length; i++)
            {
                searchLength[i] = false;
                foreach (string item in content)
                {
                    if (item.Contains(searchCriteria[i]))
                        searchLength[i] = true;
                }
            }

            // Checks all of the criteria
            foreach (bool item in searchLength)
                if (!item)
                    return false;

            return true;
        }

        // Cancels the search
        private void cancelBox_Click(object sender, EventArgs e)
        {

            deleteBox.DataSource = Form1.allInstruments;
            searchBox.Clear();
        }
    }
}
