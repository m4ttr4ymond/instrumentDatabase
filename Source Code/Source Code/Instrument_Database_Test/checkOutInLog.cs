using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform for checking in/out an instrument
    // "Constructor" gives the instrument that's data will be displayed
    public partial class checkOutInLog : Form
    {
        // Holds the content that's going to be displayed
        List<List<string>> content = new List<List<string>>();
        // Variable to hold the instrument that's data will be displayed
        Instrument instrument;
        // The last selected column and row
        int[] selectedIndex = new int[2];
        // Variable for transaction type
        string cForward;

        // Name of the student for the student Data
        string name;

        // List of the student's checkouts
        List<Checkout> studentCheckouts = new List<Checkout>();

        Checkout.Type cBackward;

        // "Constructor." Sets up the DataGridView
        public checkOutInLog(Instrument i)
        {
            InitializeComponent();
            // Display information
            checkLogDisplay.Text = "Check in and check out data for " + i.name + ": " + i.id;
            // Reverse the order of the transactions to display most recent first
            i.checkouts.Reverse();
            // Sets the variable to be worked with for the rest of the time
            instrument = i;

            populateGrid();
            // Makes all editable except for the notes and transaction type columns
            checkoutGrid.ReadOnly = false;
            checkoutGrid.Columns["Notes"].ReadOnly = true;
            checkoutGrid.Columns[0].ReadOnly = true;
            Refresh();
        }

        // Constructor for giving student information
        public checkOutInLog(string studentName)
        {
            InitializeComponent();

            // Sets the name of the student
            name = studentName;

            studentCheckouts.Clear();

            // Goes through all of the records and grabs the redord if it's by the same name
            foreach (Instrument instrument in Form1.allInstruments)
                foreach (Checkout transaction in instrument.checkouts)
                    if (transaction.sName.Equals(studentName))
                        studentCheckouts.Add(transaction);

            // Fill the graph with student xcheckout data
            populateStudentData();
        }

        // Checks to see if there is a note in the transaction
        private string isNote(Note note)
        {
            if (note.content != "")
                return "Yes";
            else
                return "No";
        }

        // Editing actions to take on double click
        private void content_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkoutGrid.CurrentCell != null && checkoutGrid.CurrentCell.Value != null)
            {
                // If the last column
                if (checkoutGrid.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
                {
                    if (instrument == null)
                    {
                        noteEntry noteView = new noteEntry(studentCheckouts[checkoutGrid.CurrentCell.RowIndex].note, studentCheckouts[checkoutGrid.CurrentCell.RowIndex].instrument.name, checkoutGrid.CurrentCell.RowIndex);
                        noteView.noteTextBox.Enabled = false;
                        noteView.noteLabel.Text = "";
                        noteView.saveButton.Hide();
                        noteView.cancelButton.Location = new Point(110, 260);
                        noteView.ShowDialog();
                    }
                    else
                    {
                        // View note
                        noteEntry noteView = new noteEntry(instrument.checkouts[checkoutGrid.CurrentCell.RowIndex].note, instrument.name, checkoutGrid.CurrentCell.RowIndex);
                        noteView.ShowDialog();
                    }
                }
                // If the first column
                else if (instrument != null && (checkoutGrid.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1) && Form1.currentEmployee != null)
                {
                    // Initializes and assigns variables for the starting and ending
                    // values of the transaction type
                    string cStart = "Check Out";
                    string cEnd = "Check In";

                    // Doing it this way saves two stirng parses

                    // If it was originally a check in, it sets it to a check out
                    switch (checkoutGrid.CurrentCell.Value.ToString())
                    {
                        case "Check In":
                            cStart = "Check In";
                            cEnd = "Check Out";
                            break;
                    }

                    // Assigns cell text value
                    checkoutGrid.CurrentCell.Value = cEnd;

                    // Notification
                    notificationForm nF = new notificationForm(cStart, cEnd);
                    nF.ShowDialog();
                    nF.Refresh();
                }
            }
        }

        // When cell is done being edited
        private void checkoutGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.currentEmployee != null)
            {
                // If the string in the first column is "Check In"
                if ((string)checkoutGrid[0, selectedIndex[1]].Value == "Check In")
                    cBackward = 0;
                else
                    cBackward = (Checkout.Type)1;

                foreach (Instrument nInstrument in Form1.allInstruments)
                {
                    if (nInstrument.id == instrument.id)
                    {
                        // Save information to the instrument
                        nInstrument.checkouts[selectedIndex[1]].type = cBackward;
                        nInstrument.checkouts[selectedIndex[1]].sName = (string)checkoutGrid[1, selectedIndex[1]].Value.ToString();
                        int temp1;

                        // Makes sure that the user inputed an actual intger
                        if (!Int32.TryParse(checkoutGrid[2, selectedIndex[1]].Value.ToString(), out temp1) | temp1.ToString().Length != 7)
                        {
                            checkoutGrid[2, selectedIndex[1]].Value = nInstrument.checkouts[selectedIndex[1]].sID;
                            notificationForm nF = new notificationForm("You must enter a 7-digit, number-only input");
                            nF.ShowDialog();
                            nF.Refresh();
                        }
                        else
                            nInstrument.checkouts[selectedIndex[1]].sID = Int32.Parse(checkoutGrid[2, selectedIndex[1]].Value.ToString());

                        nInstrument.checkouts[selectedIndex[1]].emailAddress = (string)checkoutGrid[3, selectedIndex[1]].Value.ToString();

                        DateTime temp2;

                        // Makes sure that the user inputed an actual date
                        if (!DateTime.TryParse(checkoutGrid[4, selectedIndex[1]].Value.ToString(), out temp2))
                        {
                            checkoutGrid[4, selectedIndex[1]].Value = nInstrument.checkouts[selectedIndex[1]].date;
                            notificationForm nF = new notificationForm("You must enter a correct date format");
                            nF.ShowDialog();
                            nF.Refresh();
                        }
                        else
                            nInstrument.checkouts[selectedIndex[1]].date = checkoutGrid[4, selectedIndex[1]].Value.ToString();

                        nInstrument.checkouts[selectedIndex[1]].staff = (string)checkoutGrid[5, selectedIndex[1]].Value.ToString();
                        nInstrument.checkouts[selectedIndex[1]].semester = (string)checkoutGrid[6, selectedIndex[1]].Value.ToString();

                        // Update the instrument variable in this class
                        instrument = nInstrument;

                        // Sort out instruments with the new value
                        Form1.sortInstruments();
                        break;
                    }
                }
            }
        }

        // Sets the last selected Column and row
        private void checkoutGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (instrument != null)
            {
                // If something is selected
                if (checkoutGrid.SelectedCells != null &&
                checkoutGrid.SelectedCells[0].ColumnIndex >= 0 &&
                checkoutGrid.SelectedCells[0].RowIndex >= 0)
                {
                    // Set them
                    selectedIndex[0] = checkoutGrid.SelectedCells[0].ColumnIndex;
                    selectedIndex[1] = checkoutGrid.SelectedCells[0].RowIndex;
                }
            }
        }

        // Fills out the data in the checkout grid 
        private void populateGrid()
        {
            foreach (Checkout checkout in instrument.checkouts)
            {
                // Assign transation type
                if (checkout.type == 0)
                    cForward = "Check In";
                else
                    cForward = "Check Out";

                // Add row to the DataGridView
                checkoutGrid.Rows.Add(cForward, checkout.sName, checkout.sID, checkout.emailAddress,
                                             checkout.date, checkout.staff, checkout.semester,
                                             isNote(checkout.note));
            }
        }

        // Return to previous form
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // When the form is closed
        private void checkOutInLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (instrument != null)
            {
                // Flip checkouts back
                foreach (Instrument i in Form1.allInstruments)
                    if (i.id == instrument.id)
                        i.checkouts.Reverse();
            }
        }

        // Runs when form is activated again
        private void checkOutInLog_Activated(object sender, EventArgs e)
        {
            // Sets the value of the note column
            if (instrument != null && instrument.checkouts.Count > 0)
            {
                checkoutGrid.Rows[selectedIndex[1]].Cells[7].Value = isNote(instrument.checkouts[selectedIndex[1]].note);
                Refresh();
            }
        }

        // Fill the grid with the student data
        private void populateStudentData()
        {
            // Set up ccolumns
            checkoutGrid.Columns["sName"].HeaderText = "Instrument Name";
            checkoutGrid.Columns["sName"].Name = "iName";

            checkoutGrid.Columns["sID"].HeaderText = "Bow #";
            checkoutGrid.Columns["sID"].Name = "bowID";

            checkoutGrid.Columns["sEmail"].HeaderText = "Instrument ID";
            checkoutGrid.Columns["sEmail"].Name = "iID";

            // reverse information so that the most recent are at the top
            List<Checkout> myCheckout = studentCheckouts;
            myCheckout.Reverse();

            // Fill the grid
            foreach (Checkout checkout in myCheckout)
            {
                checkoutGrid.Rows.Add(checkout.type, checkout.instrument.name,
                                      checkout.instrument.bow.ToString(),
                                      checkout.instrument.id.ToString(),
                                      checkout.date, checkout.staff, checkout.semester,
                                      isNote(checkout.note));
            }
        }
    }
}
