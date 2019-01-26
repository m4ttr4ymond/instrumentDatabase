using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform for checking in/out an instrument
    // "Constructor" allows you to have it as either a check in or check out window
    public partial class Checkout_Data : Form
    {
        // Whether the student is already in the system
        bool contains = false;

        // NoteEntry form created for later use
        noteEntry nE = new noteEntry();

        // Creates a radiobutton object
        RadioButton semester;

        // Checkout type variable (check in or check out)
        Checkout.Type checkType;

        public InstrumentData fullData = new InstrumentData();

        // "Constructor." Takes in an instrument object and a checkout type
        public Checkout_Data(Instrument instrument, Checkout.Type type)
        {
            InitializeComponent();
            // Assigns an id to coInstrument
            //coInstrument = instrument.id;
            // Selects the fall semester button
            fallButton.Select();
            // Selects the current day
            checkoutDate.Select();
            this.checkType = type;

            //////////////////
            fullData.bow = instrument.bow;
            fullData.brand = instrument.brand;
            fullData.cabinate = instrument.cabinate;
            fullData.id = instrument.id;
            fullData.model = instrument.model;
            fullData.name = instrument.name;
            fullData.note = instrument.note;
            fullData.serialNumber = instrument.serialNumber;
            fullData.type = instrument.type;
            fullData.value = instrument.value;
            fullData.vendor = instrument.vendor;
            //////////////////

            // Sets the check in/out button text depending on whether this is
            // a check in or check out
            switch (checkType)
            {
                case (Checkout.Type.checkin):
                    {
                        checkoutButton.Text = "Check In";
                        break;
                    }
                case (Checkout.Type.checkout):
                    {
                        checkoutButton.Text = "Check Out";
                        break;
                    }
            }

            // Autofills the employee box
            staffBox.Text = Form1.currentEmployee.eName;

            // Moves the user focus to enter the student id
                // Technically not necessary, but makes the card scanner more convenient
                // as you don't have to do anything besides open the form then
            sIDBox.Select();
            Refresh();
        }

        // Check to make sure that everything is in order and check in/out the instrument
        private void checkout_Button(object sender, EventArgs e)
        {
            checkID();
        }

        // Leaves the checkout screen when the cancel button is hit
        private void cancel_Button(object sender, EventArgs e)
        {
            Close();
        }

        // Changes the semester variable when the radiobutton changes
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            semester = (RadioButton) sender;
        }
        
        // Checks to see if the current input is a name or not
        public bool isName(string source)
        {
            // String that contains all of the characters allowed in a name
            string alphabetic = "qwertyuiopasdfghjklzxcvbnm-' ";

            // Returns true if the name only contains chars from alphabetic
            foreach (char character in source.ToLower())
                if (!alphabetic.Contains(character))
                    return false;
            // Otherwise it reaches here and returns true
            return true;
        }

        // Shows the note editor when the "Add Note" button is clicked
        private void noteButton_Click(object sender, EventArgs e)
        {
            nE.Show();
        }

        // Capitalize the given string
        public static string capitalizeName(string fullName)
        {
            // Appears more complicated than necessary, but ensures that
            // it will work for people with 3, 4, or more names as
            // opposed to just 2

            // List to contain the name separated at spaces
            List<string> nameParts = new List<string>();
            while (fullName.Contains(" "))
            {
                // Adds the current first name to the list
                nameParts.Add(fullName.Remove(fullName.IndexOf(" ")));
                // Removes that name from fullName
                fullName = fullName.Substring(fullName.IndexOf(" ")+1);
            }
            // Add the last bit of the name to the name list
            nameParts.Add(fullName);

            // Clear name
            fullName = "";

            foreach(string part in nameParts)
            {
                // Set correct capitalization for that part of the name,
                // appends to fullName, and appends a space
                fullName += part.ToUpper()[0] + part.ToLower().Substring(1) + " ";
            }
            // The last extra space on the end is removed
            fullName = fullName.Remove(fullName.Length - 1);
            return fullName;
        }

        // Add the new transaction to the correct instrument
        private void setInstrument(Checkout checkout)
        {
            foreach (Instrument instrument in Form1.allInstruments)
            {
                // If the two id's match
                if (instrument.id == fullData.id)
                {
                    instrument.checkouts.Add(checkout);
                    Form1.sortInstruments();
                    break;
                }
            }            
        }

        // Auto-fills student info boxes if the student is in the system
        private void sIDBox_Leave(object sender, EventArgs e)
        {
            foreach (StudentData student in Form1.students)
            {
                // If the student ID is in the database
                if (sIDBox.Text != "" && student.sID == Int32.Parse(sIDBox.Text))
                {
                    // Auto-fill
                    sNameBox.Text = student.sName;
                    sEmailBox.Text = student.emailAddress;
                    customEmail.Checked = true;
                    // Set to true to prevent te student from being added again
                    contains = true;
                    break;
                }
            }
            
        }

        // Filtering data for card swipe
        private void sIDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This method is written to work with input from:
            //  - IdTech IDMB-334112B MiniMag II Magstrip Reader

            // Card swipe returns numbers in the format ";00xxxxxxx=yyyy?"
            // where x's are the ID number and y's are irrelevant chars

            // If it contains all character consistantly returned by card reader
            if (e.KeyChar == (char)13 && sIDBox.Text.Contains(";")
                                     && sIDBox.Text.Contains("=")
                                     && sIDBox.Text.Contains("?"))
            {
                // Clean up the input
                string tempString = sIDBox.Text.Remove(sIDBox.Text.IndexOf("="));
                tempString = tempString.Substring(3);
                sIDBox.Text = tempString;

                Refresh();

                // Move on to the name box
                sNameBox.Select();
                sIDBox_Leave(sender, e);
            }
        }

        // checks the ID number
        private void checkID()
        {
            // If the ID input is all numbers
            int throwaway;
            if (Int32.TryParse(sIDBox.Text, out throwaway))
            {
                // Reset the instructional text
                sIDLabel.ForeColor = Color.Black;
                sIDLabel.Text = "Student ID";

                // If the number is preceded by two zeros
                // This is specific to my school
                // For whatever reason all of our ID numbers are preceded
                // by two zeros, and everyone just ignores them
                if (sIDBox.Text.Length > 2 && sIDBox.Text.Substring(0, 2) == "00")
                    sIDBox.Text = sIDBox.Text.Remove(0, 2);

                // Checks the name
                nameCheck();
            }
            else
            {
                // Error
                sIDLabel.ForeColor = Color.DarkRed;
                sIDLabel.Text = "Only numbers please";
            }
        }

        // Checks the name box
        private void nameCheck()
        {
            // If false, the program will skip the rest of the if statements
            // after the email check
            bool checking = true;

            // If the given name is valid
            if (isName(sNameBox.Text) & sNameBox.Text.Length > 0)
            {
                // Reset the instructional text
                sNameLabel.ForeColor = Color.Black;
                sNameLabel.Text = "Name";

                // Capitalize the name
                sNameBox.Text = capitalizeName(sNameBox.Text);

                // Checks the entered email
                checking = emailCheck(checking);
            }
            else
            {
                // Error
                sNameLabel.ForeColor = Color.DarkRed;
                sNameLabel.Text = "Only letters please";
            }
        }

        // Checks the email box
        private bool emailCheck(bool checking)
        {
            // if email isn't blank
            if (sEmailBox.Text.Length > 0)
            {
                // Reset the instructional text
                sEmailLabel.ForeColor = Color.Black;
                sEmailLabel.Text = "Email Address";

                // Email variable
                string emailAddress = sEmailBox.Text;

                // If the new email domain is checked
                // Recently the school switched from one domain to another
                // years 1-2 have the new, years 3-4 have the old
                if (newEmail.Checked & !sEmailBox.Text.Contains("@"))
                    emailAddress += "@chapman.edu";

                // If the old email domain is checked
                else if (oldEmail.Checked & !sEmailBox.Text.Contains("@"))
                    emailAddress += "@mail.chapman.edu";

                // If a custom domain is chosen and there is no domain specified
                else if (!sEmailBox.Text.Contains("@"))
                {
                    // Warning
                    sEmailLabel.ForeColor = Color.DarkRed;
                    sEmailLabel.Text = "Domain required for email";
                    // skip out of the rest of the if statements
                    return false;
                }

                // Checks the staff
                staffCheck(emailAddress, checking);
                return true;
            }
            else
            {
                // Error
                sEmailLabel.ForeColor = Color.DarkRed;
                sEmailLabel.Text = "Email cannot be blank";
                return false;
            }
        }

        // Checks the staff box
        private void staffCheck(string emailAddress, bool checking)
        {
            // If there is a staff member inputed
            if (staffBox.Text.Length > 0 && checking)
            {
                // Reset the instructional text
                staffNameLabel.ForeColor = Color.Black;
                staffNameLabel.Text = "Staff";
                // Capitalize the name
                staffBox.Text = capitalizeName(staffBox.Text);

                // Complete the transaction
                transaction(emailAddress);
                // Close the note editor
                nE.Close();
                Close();
            }
            else if (checking)
            {
                // Error
                staffNameLabel.ForeColor = Color.DarkRed;
                staffNameLabel.Text = "Enter staff";
            }
        }

        // Does the actual checking in/out of the instrument
        private void transaction(string emailAddress)
        {
            // Sets the date from the calendar object
            string cDate = checkoutDate.SelectionRange.Start.ToString();
            cDate = cDate.Remove(cDate.IndexOf(" "));

            // Creates a new checkout object from the data
            Checkout checkout = new Checkout(sNameBox.Text, Int32.Parse(sIDBox.Text),
                             emailAddress, cDate,
                             staffBox.Text, semester.Text, checkType, fullData);

            // Not incuded in the constructor because I didn't want to create
            // an overloaded constructor ust to save one line. I'd net a loss
            // of about 15 lines to remove this one
            checkout.note = nE.note;

            // Adds the transaction to the correct instrument
            setInstrument(checkout);

            // If the student is not already in the system
            if (!contains)
                // Add the student to the list of students
                Form1.students.Add(new StudentData(sNameBox.Text,
                                                   Int32.Parse(sIDBox.Text),
                                                   emailAddress));
            else
                contains = false;
        }
    }
}
