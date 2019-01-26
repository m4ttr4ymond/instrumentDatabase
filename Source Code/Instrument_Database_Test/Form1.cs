using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Instrument_Database_Test
{
    // Main winform that contols everything else
    // Also the main view into the instrument library
    public partial class Form1 : Form
    {
        Button lastSelected;

        // Staffing
        public static BindingList<Employees> currentStaff = new BindingList<Employees>();
        public static Employees currentEmployee;

        public static string versionNumber = "v1.2";

        // Students
        public static BindingList<StudentData> students = new BindingList<StudentData>();

        // Filing
        public static string filepath = Application.StartupPath + "\\LibraryData";

        // Instruments
        public static BindingList<Instrument> allInstruments = new BindingList<Instrument>();
        //--//
        public static BindingList<Instrument> brass = new BindingList<Instrument>();
        public static BindingList<Instrument> percussion = new BindingList<Instrument>();
        public static BindingList<Instrument> strings = new BindingList<Instrument>();
        public static BindingList<Instrument> woodwinds = new BindingList<Instrument>();
        public static BindingList<Instrument> ema = new BindingList<Instrument>();
        public static BindingList<Instrument> microphone = new BindingList<Instrument>();
        public static BindingList<Instrument> mute = new BindingList<Instrument>();
        public static BindingList<Instrument> other = new BindingList<Instrument>();
        //--//
        public static List<BindingList<Instrument>> libraryRecords = new List<BindingList<Instrument>>()
            { allInstruments, brass, percussion, strings, woodwinds, ema, microphone, mute, other };

        // Search
        BindingList<Instrument> searchResults = new BindingList<Instrument>();

        // "Contructor"
        public Form1()
        {
            InitializeComponent();

            //new SplashScreen();

            instrumentList.DataSource = allInstruments;
            newDataDisplay.Text = "";
            setFilepath();
            instrumentList.Select();
            // Sort instruments into their respective lists
            sortInstruments();
            searchBox.Select();

            // Select employee
            if (currentStaff.Count != 0)
            {
                employeeSelect eS = new employeeSelect();
                eS.ShowDialog();
            }
            this.Text = currentEmployee + ": " + versionNumber;
        }

        // Sets the instrument data overview
        private void instrumentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instrument temp = (Instrument)instrumentList.SelectedItem;
            // Makes sure that an instrument is actually selected
            if (temp != null)
                newDataDisplay.Text = temp.returnData();
        }

        // Brings up the window to add instruments to the database
        private void addButton_Click(object sender, EventArgs e)
        {
            // Checks to make sure that the person has administrative access
            if (currentEmployee != null && currentEmployee.password != null)
            {
                Data_Form instrumentWizard = new Data_Form();
                instrumentWizard.ShowDialog();
                
            }
            else
                adminForm();
        }

        // Saves to a file
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveToFile.serializeAll();
        }

        // Sets the filepath for the program and populates the directories
        private void setFilepath()
        {
            if (!Directory.Exists(filepath))
                Directory.CreateDirectory(filepath);

            // If the file does not already exist, create it, otherwise, deserialize
            if (!File.Exists(filepath + "\\InstrumentData.xml"))
                File.Create(filepath + "\\InstrumentData.xml").Close();
            else
            {
                SaveToFile.deserialize(0);
                instrumentList.DataSource = allInstruments;
            }

            // If the file does not already exist, create it, otherwise, deserialize
            if (!File.Exists(filepath + "\\StudentData.xml"))
                File.Create(filepath + "\\StudentData.xml").Close();
            else SaveToFile.deserialize(1);

            // If the file does not already exist, create it, otherwise, deserialize
            if (!File.Exists(filepath + "\\Employees.xml"))
            {
                File.Create(filepath + "\\Employees.xml").Close();

                // Add employee dialoge
                employeeAdd eA = new employeeAdd(0);
                eA.ShowDialog();
            }
            else SaveToFile.deserialize(2);

            Refresh();
        }

        // Sorts all of the instruments into their respective catagories
        public static void sortInstruments()
        {
            foreach (BindingList<Instrument> list in libraryRecords.Skip(1))
                list.Clear();

            // Sort
            foreach (Instrument instrument in allInstruments)
                typeSwitch(instrument);
        }

        // Adds individual insruments to their respective catagories
        public static void typeSwitch(Instrument i)
        {
            switch (i.type)
            {
                case Instrument.Catagory.Brass:
                    brass.Add(i);
                    break;
                case Instrument.Catagory.Percussion:
                    percussion.Add(i);
                    break;
                case Instrument.Catagory.Strings:
                    strings.Add(i);
                    break;
                case Instrument.Catagory.Woodwinds:
                    woodwinds.Add(i);
                    break;
                case Instrument.Catagory.EMA:
                    ema.Add(i);
                    break;
                case Instrument.Catagory.Microphone:
                    microphone.Add(i);
                    break;
                case Instrument.Catagory.Mute:
                    mute.Add(i);
                    break;
                case Instrument.Catagory.Other:
                    other.Add(i);
                    break;
            }
        }

        // Basically a custom tabindex
        private void changeIndex(object sender, EventArgs e)
        {
            if (lastSelected != null)
                lastSelected.BackColor = SystemColors.ControlLight;

            Button k = (Button)sender;
            k.BackColor = SystemColors.ControlDark;
            lastSelected = k;
            switch (sender.ToString().Substring(35))
            {
                case ("All Instruments"):
                    instrumentList.DataSource = allInstruments;
                    break;
                case ("Brass"):
                    instrumentList.DataSource = brass;
                    break;
                case ("Percussion"):
                    instrumentList.DataSource = percussion;
                    break;
                case ("Strings"):
                    instrumentList.DataSource = strings;
                    break;
                case ("Woodwinds"):
                    instrumentList.DataSource = woodwinds;
                    break;
                case ("EMA"):
                    instrumentList.DataSource = ema;
                    break;
                case ("Microphone"):
                    instrumentList.DataSource = microphone;
                    break;
                case ("Mutes"):
                    instrumentList.DataSource = mute;
                    break;
                case ("Other"):
                    instrumentList.DataSource = other;
                    break;
            }
            Refresh();
        }

        // Opens the window to delete an instrument
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Checks to make sure that the employee has the correct permissions
            if (currentEmployee != null && currentEmployee.password != null)
            {
                Delete_Form delete = new Delete_Form();
                delete.ShowDialog();
            }
            else
                adminForm();
        }

        // Searches through the content for a specific instrument
        private void searchButton_Click(object sender, EventArgs e)
        {
            searching();
            searchBox.SelectAll();
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
            instrumentList.DataSource = searchResults;
            if(instrumentList.SelectedIndex >=0)
                instrumentList.SetSelected(instrumentList.SelectedIndex, true);
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
            changeIndex((object)allInstrumentsButton, new EventArgs());
            //instrumentList.DataSource = allInstruments;
            searchBox.Clear();
        }

        // Opens up the check out screen
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee != null)
            {
                // Selected instrument
                Instrument tempInstrument = (Instrument)instrumentList.SelectedItem;

                // If there's anything in library
                if (allInstruments.Count > 0)
                {
                    // And there are any checkouts, make sure that it's not still checked out
                    if (tempInstrument.checkouts.Count > 0)
                    {
                        if (tempInstrument.checkouts[tempInstrument.checkouts.Count - 1].type != (Checkout.Type)1)
                        {
                            Checkout_Data mCheckout = new Checkout_Data(tempInstrument, Checkout.Type.checkout);
                            mCheckout.Text = "Check Out";
                            mCheckout.ShowDialog();
                        }
                    }
                    // Otherwise, just check it out
                    else
                    {
                        Checkout_Data checkout = new Checkout_Data(tempInstrument, Checkout.Type.checkout);
                        checkout.Text = "Check Out";
                        checkout.ShowDialog();
                    }
                }
            }
        }

        // Opens up the check in screen
        private void checkInButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee != null)
            {
                // Selected instrument
                Instrument tempInstrument = (Instrument)instrumentList.SelectedItem;

                // If there are any instruments
                if (allInstruments.Count > 0)
                {
                    // If the instrument has been checked out and 
                    if (tempInstrument.checkouts.Count > 0 && tempInstrument.checkouts != null)
                    {
                        // Checks to make sure that you can't check it in whle it's in
                        if (tempInstrument.checkouts[tempInstrument.checkouts.Count - 1].type != (Checkout.Type)0)
                        {
                            Checkout_Data mCheckout = new Checkout_Data((Instrument)instrumentList.SelectedItem, Checkout.Type.checkin);
                            mCheckout.Text = "Check In";
                            mCheckout.ShowDialog();
                        }
                    }
                    // Otherwise, just run it
                    else
                    {
                        Checkout_Data checkout = new Checkout_Data((Instrument)instrumentList.SelectedItem, Checkout.Type.checkin);
                        checkout.Text = "Check In";
                        checkout.ShowDialog();
                    }
                }
            }
                
        }

        // Opens the check in/out log
        private void checkLogButton_Click(object sender, EventArgs e)
        {
            // If there's something selected
            if (instrumentList.SelectedItem != null)
            {
                checkOutInLog check = new checkOutInLog((Instrument)instrumentList.SelectedItem);
                check.ShowDialog();
            }
        }

        // Marks the instrument as missing
        private void missingButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee != null)
            {
                // If there are any instruments in the library
                if (allInstruments.Count > 0)
                {
                    // Finds the id of the selected instrument
                    Instrument tempI = (Instrument)instrumentList.SelectedItem;
                    string i = tempI.id;

                    foreach (Instrument instrument in allInstruments)
                    {
                        if (instrument.id.Equals(i))
                        {
                            switch (instrument.status)
                            {
                                case Instrument.Status.Missing:
                                    instrument.status = (Instrument.Status)1;
                                    break;
                                case Instrument.Status.Found:
                                    instrument.status = (Instrument.Status)0;
                                    break;
                            }
                            // Creates a new Binding list for Datasource because otherwise it doesn't
                            // work for some reason
                            BindingList<Instrument> tempB = new BindingList<Instrument>();
                            tempB.Add(instrument);
                            instrumentList.DataSource = tempB;
                            instrumentList.DataSource = allInstruments;
                        }
                    }
                    sortInstruments();
                    Refresh();
                }
            }
        }

        // Exports instrument data to csv file
        private void csvExportButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee != null)
            {
                // Create filepath
                string exportD = filepath + "\\Exports";

                // Make directory
                if (!Directory.Exists(exportD))
                    Directory.CreateDirectory(exportD);

                // If there are any instruments in the library
                if (allInstruments.Count > 0)
                {
                    // Open the save file dialogue to export
                    SaveFileDialog sfd = new SaveFileDialog();

                    // Filter out everything that's not a csv file
                    sfd.Filter = "CSV files|*.csv|All files|*";

                    // set filepath
                    string sfdname = sfd.FileName;
                    sfd.InitialDirectory = exportD;

                    string fullPath;

                    int version = 1;

                    // Automatically names it so that it doesn't overwrite n old one by default
                    foreach (string export in Directory.GetFiles(exportD, "Export*.csv"))
                    {
                        string fileName = "Export" + version + ".csv";
                        if (!File.Exists(exportD + "\\" + fileName))
                        {
                            sfd.FileName = fileName;
                            break;
                        }
                        else
                            version++;
                    }

                    sfd.FileName = "Export" + version;

                    // Save file
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        fullPath = Path.GetFullPath(sfd.FileName);
                        csvExporter.export(fullPath);
                    }
                }
            }
            
        }

        // Opens up add employees winform
        private void addEmployeesButton_Click(object sender, EventArgs e)
        {
            // If there's an emplyee and they have a password
            if (currentEmployee != null && currentEmployee.password != null)
            {
                employeeAdd aE = new employeeAdd(0);
                aE.ShowDialog();
            }
            // Otherwise, reject them
            else
                adminForm();
        }

        // Tells te user that they need admin permissions
        private void adminForm()
        {
            notificationForm nF = new notificationForm("You need admin permissions to access this screen");
            nF.ShowDialog();
            SystemSounds.Beep.Play();
        }

        // Opens up change employee winform
        private void changeEmployeeButton_Click(object sender, EventArgs e)
        {
            // If there's any staff
            if (Form1.currentStaff.Count > 0)
            {
                employeeSelect eS = new employeeSelect();
                eS.ShowDialog();
            }
            else
            {
                employeeAdd aE = new employeeAdd(1);
                aE.ShowDialog();
            }
            // Display what employee is logged in
            this.Text = currentEmployee + ": " + versionNumber;

            Refresh();
        }

        // Search function for scanner
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lastSelected != null)
                lastSelected.BackColor = SystemColors.ControlLight;
            allInstrumentsButton.BackColor = SystemColors.ControlDark;
            // If it's enter
            if (e.KeyChar == (char)13)
                searchButton_Click(sender, e);
            // Backspace key
            else if (e.KeyChar == (char)8)
                searching("", true);
            else
                searching(e.KeyChar.ToString());
        }

        // Import backup
        private void importButton_Click(object sender, EventArgs e)
        {
            // If there employee isn't empty and if they have admin permissions
            if (currentEmployee != null && currentEmployee.password != null)
            {
                // File explorer
                string fullPath = "";
                OpenFileDialog ofd = new OpenFileDialog();

                // filter out filetypes
                ofd.Filter = "Backup Files|*.icrb";

                // Create filepath
                string sfdname = ofd.FileName;
                ofd.InitialDirectory = filepath + "\\LibraryData\\Backups";

                // If ok is clicked, backup
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Path.GetFullPath(ofd.FileName);

                    // Warn the user that their information will be overwritten and there will be no way to undo it
                    askBackupForm aBF = new askBackupForm();
                    aBF.ShowDialog();

                    fullPath = Path.GetFullPath(ofd.FileName);

                    SaveToFile.populateBackup(fullPath);
                    Refresh();
                }
            }
            else
                adminForm();
        }

        // When form is closing
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form1.currentStaff.Count == 0)
                File.Delete(filepath + "\\Employees.xml");

            SaveToFile.serializeAll();

            // Perform backup if necessary
            backupFunction.performBackup(filepath);
        }

        // Does a manual backup when clicked
        private void backupButton_Click(object sender, EventArgs e)
        {
            // If the employee isn't null and if they have admin permissions
            if (currentEmployee != null && currentEmployee.password != null)
                backupFunction.backupRun(filepath);
            else
                adminForm();
        }

        // Pull up data for the most popular day of the week
        private void dataButton_Click(object sender, EventArgs e)
        {
            DataDisplay mpd = new DataDisplay();
            mpd.Show();
        }

        // Pull up data for students
        private void checkoutsPerStudent_Click(object sender, EventArgs e)
        {
            CheckoutsPerStudent cops = new CheckoutsPerStudent();
            cops.ShowDialog();
        }
    }
}
