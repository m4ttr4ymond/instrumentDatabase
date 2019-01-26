using System;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform for entering a note to a transaction
    public partial class noteEntry : Form
    {
        // The instrument's name to display
        string instrumentName;

        // The note being written to. This allows it to edit an old note
        int index;

        // Note object
        public Note note = new Note();

        // Whether the note is new or editing an old one
        enum Setting { New, Renew };
        Setting current;

        // "Constructor" 1 - Normal note entry
        public noteEntry()
        {
            InitializeComponent();
            // New note
            current = (Setting) 0;
            noteTextBox.Select();
        }
        
        // "Constructor" 2 - Editing already-written note
        public noteEntry(Note note, string name, int index)
        {
            // Takes old note, the instrument name, and the index of the transaction
            // as parameters


            InitializeComponent();
            // editing old note
            current = (Setting) 1;
            // Set instrument name and index of transaction
            instrumentName = name;
            this.index = index;

            // Initializes the contents of the box
            noteTextBox.Text = note.content;
            noteTextBox.Select(0, 0);
            noteTextBox.Select();
        }

        // Close if cancel button is hit
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Save to transaction when save is hit
        private void saveButton_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                // If it's a new note
                case Setting.New:
                    note.content = noteTextBox.Text;
                    this.Visible = false;
                    break;
                // If it's an old note being edited
                case Setting.Renew:
                    foreach (Instrument instrument in Form1.allInstruments)
                        if (instrument.name == instrumentName)
                            instrument.checkouts[index].note.content = noteTextBox.Text;
                                                     
                    this.Close();
                    break;
            }
        }
    }
}
