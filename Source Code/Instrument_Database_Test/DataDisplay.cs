using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// ToDo: Fix the instrument name numbers, and make the form look ok when there's no information to show

namespace Instrument_Database_Test
{
    // This winform creates a graph that shows what da pf the week is the most popular for checkouts
    public partial class DataDisplay : Form
    {
        // Variables for PerStudent Enum
        Dictionary<string, int> students = new Dictionary<string, int>();
        Dictionary<string, Dictionary<DateTime, int>> studentCheckouts = new Dictionary<string, Dictionary<DateTime, int>>();
        Dictionary<string, Dictionary<DateTime, int>> studentCheckins = new Dictionary<string, Dictionary<DateTime, int>>();
        List<KeyValuePair<string, int>> sortedStudents = new List<KeyValuePair<string, int>>();

        // Variables for PerEmployee Enum
        Dictionary<string, int> employees = new Dictionary<string, int>();
        Dictionary<string, Dictionary<DateTime, int>> employeeTransactions = new Dictionary<string, Dictionary<DateTime, int>>();
        List<KeyValuePair<string, int>> sortedEmployees = new List<KeyValuePair<string, int>>();

        // Variables for PerInstrument Enum
        Dictionary<Instrument, int> instruments = new Dictionary<Instrument, int>();
        Dictionary<DateTime, int> instrumentCheckins = new Dictionary<DateTime, int>();
        Dictionary<DateTime, int> instrumentCheckouts = new Dictionary<DateTime, int>();
        List<KeyValuePair<Instrument, int>> sortedInstruments = new List<KeyValuePair<Instrument, int>>();

        // Dates for the search functions
        DateTime backLimit;
        DateTime frontLimit;

        string instrumentName = "";

        // Variables shared by many modes
        Point panelPoint = new Point(550, 80);

        Mode currentMode;

        // Enum for the days of the week
        private enum DayOfWeek
        {
            Mon = 0,
            Tues = 1,
            Wed = 2,
            Thurs = 3,
            Fri = 4,
            Sat = 5,
            Sun = 6
        }

        // What kind of data is being looked at
        public enum Mode
        {
            Instruments,
            Students,
            Employees,
            perTime
        }

        // What the smallest unit of time is
        public enum TimeSubMode
        {
            Hour,
            Day,
            Week,
            Semester,
            None
        }

        // Constructor
        public DataDisplay(/*Mode mainMode, TimeSubMode subMode = TimeSubMode.None*/)
        {
            InitializeComponent();

            RankingPanel.Location = panelPoint;
            studentPanel.Location = panelPoint;
            optionPanel.Location = new Point((panelPoint.X+20), (panelPoint.Y + studentPanel.Height));

            // Things not to see
            RankingPanel.Visible = false;

            // Things to see
            studentPanel.Visible = true;

            this.Size = new Size(950, 600);
            this.MaximumSize = this.MinimumSize = this.Size;


            backLimit = DateTime.Parse("1/1/2000");
            frontLimit = DateTime.Now;

            startCalendar.SetDate(backLimit);

            studentRadio.Select();
        }

        // Sets up the form for the "per student" analytics
        private void perStudentSetup()
        {
            // Loading Data
            combinedLoadInfo();
            combinedPopulateChart();

            students.Clear();
            foreach (var item in sortedStudents)
                students.Add(item.Key, item.Value);

            combinedPopulateOthers(Mode.Students, students);
        }

        // Sets up the form for the "per employee" analytics
        private void perEmployeeSetup()
        {
            // Loading Data
            combinedLoadInfo();
            combinedPopulateChart();

            employees.Clear();
            foreach (var item in sortedEmployees)
                employees.Add(item.Key, item.Value);

            combinedPopulateOthers(Mode.Employees, employees);
        }

        // Sets up the form for the "per Insrument" option
        private void perInstrumentSetup()
        {
            // Loading Data
            combinedLoadInfo();
            combinedPopulateChart();

            // Turn the instruments into a form that can be sorted
            Dictionary<string, int> tempDict = new Dictionary<string, int>();
            foreach (KeyValuePair<Instrument, int> instrument in sortedInstruments)
                tempDict.Add(instrument.Key.id, instrument.Value);

            combinedPopulateOthers(Mode.Instruments, tempDict);
        }

        // Load all of the infromation for the graphs
        private void combinedLoadInfo()
        {
            employeeTransactions.Clear();
            employees.Clear();
            studentCheckins.Clear();
            studentCheckouts.Clear();
            sortedStudents.Clear();
            sortedInstruments.Clear();
            sortedEmployees.Clear();
            students.Clear();

            // Empty Dictionary variable
            Dictionary<DateTime, int> emptyDictionary = new Dictionary<DateTime, int>();

            // Makes sure that all current employees show up
            if (currentMode == Mode.Employees)
            {
                foreach (Employees employee in Form1.currentStaff)
                {
                    employeeTransactions.Add(employee.eName, new Dictionary<DateTime, int>());
                    employees.Add(employee.eName, 0);
                }
            }

            Dictionary<Instrument, int> tempDict = new Dictionary<Instrument, int>();

            // Assigns the data
            foreach (Instrument instrument in Form1.allInstruments)
            {
                foreach (Checkout transaction in instrument.checkouts)
                {
                    // If the mode is students
                    if (currentMode == Mode.Students)
                    {
                        DateTime tempDate = DateTime.Parse(transaction.date);

                        // if the checkout type is a checkout
                        if ((transaction.type == (Checkout.Type)1) && ((tempDate >= backLimit) && (tempDate <= frontLimit)))
                            // Add one to the transaction
                            if (!students.ContainsKey(transaction.sName))
                                students.Add(transaction.sName, 1);
                            else
                                students[transaction.sName]++;
                    }
                    // If the mode is employees
                    else if (currentMode == Mode.Employees)
                    {
                        // Make the datetime object so it doesn't have to keep getting made
                        DateTime tempDate = DateTime.Parse(transaction.date);

                        if ((tempDate >= backLimit) && (tempDate <= frontLimit))
                        {
                            // if there is no staff of if the staff doesn't contain a specific person
                            if (employeeTransactions[transaction.staff] == emptyDictionary || !employeeTransactions[transaction.staff].ContainsKey(tempDate))
                                employeeTransactions[transaction.staff].Add(tempDate, 1);
                            else
                                employeeTransactions[transaction.staff][tempDate]++;

                            employees[transaction.staff]++;
                        }
                    }
                    else if (currentMode == Mode.Instruments)
                    {
                        // Make the datetime object so it doesn't have to keep getting made
                        DateTime tempDate = DateTime.Parse(transaction.date);

                        if ((tempDate >= backLimit) && (tempDate <= frontLimit))
                        {
                            if(tempDict.ContainsKey(instrument))
                            {
                                tempDict[instrument]++;
                            }
                            else
                            {
                                tempDict.Add(instrument, 1);
                            }
                        }
                    }
                }
            }

            if (currentMode == Mode.Instruments)
            {
                sortedInstruments = (from entry in tempDict orderby entry.Value descending select entry).ToList<KeyValuePair<Instrument, int>>();
            }
        }

        // Populate all of the information for the person panel
        private void combinedPopulateOthers(Mode currentMode, Dictionary<string, int> currentDict)
        {
            studentListLabel.Text = currentMode.ToString();

            // String of students
            BindingList<string> namesAndNums = new BindingList<string>();

            if(currentMode!=Mode.Instruments)
            {
                // Add person and the number of things that they checked out
                foreach (KeyValuePair<string, int> item in currentDict)
                    namesAndNums.Add(item.Key + ": " + item.Value);
            }
            else
            {
                // Add person and the number of things that they checked out
                foreach (KeyValuePair<string, int> item in currentDict)
                    namesAndNums.Add(item.Key + ": " + item.Value);
            }
            

            studentList.DataSource = namesAndNums;
        }

        // Add the given datapoint to the chart
        private void addToChart(Dictionary<string, int> source, string title)
        {
            foreach (KeyValuePair<string, int> pair in source)
                barChart.Series[title].Points.AddXY(pair.Key, pair.Value);
        }

        // A sub-sort based on the students
        private void sortMini(Dictionary<string, int> source, List<KeyValuePair<string, int>> destination)
        {
            destination.Clear();
            foreach (KeyValuePair<string, int> item in source.Reverse())
                destination.Add(item);
        }

        // Populate the chart with the datapoints found
        private void combinedPopulateChart()
        {
            barChart.Series.Clear();

            string title = "";

            // Choose the title
            switch (currentMode)
            {
                case Mode.Instruments:
                    title = "Checkouts/Instrument";
                    break;
                case Mode.Students:
                    title = "Checkouts/Student";
                    break;
                case Mode.Employees:
                    title = "Transactions/Employee";
                    break;
                case Mode.perTime:
                    break;
            }

            // Add the title
            barChart.Series.Add(title);
            barChart.Series[title].ChartType = SeriesChartType.Bar;

            // Creates a source for the display data to be put in and then drawn from
            Dictionary<string, int> source = new Dictionary<string, int>();

            // Select the current mode
            switch (currentMode)
            {
                // Sort instruments
                case Mode.Instruments:
                    for(int i = sortedInstruments.Count(); i > 0; --i)
                    {
                        source.Add(sortedInstruments[i - 1].Key.id,
                                   sortedInstruments[i - 1].Value);
                    }
                    break;
                // Sort students
                case Mode.Students:
                    // Sorts the data
                    List<KeyValuePair<string, int>> tempSortS = (from entry in students orderby entry.Value ascending select entry).ToList<KeyValuePair<string, int>>(); ;
                    for (int i = tempSortS.Count; i > 0; --i)
                    {
                        // Adds the student data to sorted students and the source
                        sortedStudents.Add(tempSortS[i - 1]);
                        source.Add(tempSortS[i - 1].Key, tempSortS[i - 1].Value);
                    }
                    break;
                // Sort Students
                case Mode.Employees:
                    // Sorts the data
                    List<KeyValuePair<string, int>> tempSortE = (from entry in employees orderby entry.Value ascending select entry).ToList<KeyValuePair<string, int>>();

                    for(int i = tempSortE.Count; i > 0; --i)
                    {
                        // Adds to sorted employees and source
                        sortedEmployees.Add(tempSortE[i-1]);
                        source.Add(tempSortE[i - 1].Key, tempSortE[i - 1].Value);
                    }
                    break;
                // ToDo: write it so that it can sort based on time
                case Mode.perTime:
                    break;
            }

            addToChart(source, title);

            switch (currentMode)
            {
                case Mode.Instruments:
                    break;
                case Mode.Students:
                    // Add the students to the list to be displayed
                    //sortMini(source, sortedStudents);
                    break;
                case Mode.Employees:
                    // Add the students to the list to be displayed
                    //sortMini(source, sortedEmployees);
                    break;
                case Mode.perTime:
                    break;
            }

            // Sets the size of the bars
            barChart.Series[title]["PixelPointWidth"] = "15";

            if(barChart.Series[title].Points.Count == 0)
            {
                barChart.Series[title].Points.AddXY("No Data\nAvailable", 0);
            }
        }

        // When the cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear all prior information
        private void clearSecondaryChart()
        {
            lineChart.Series.Clear();
            studentCheckins.Clear();
            studentCheckouts.Clear();
            instrumentCheckins.Clear();
            instrumentCheckouts.Clear();
            employeeTransactions.Clear();
        }

        // What happens when you click on the name of an object in the side display
        private void studentList_ClickStudent(object sender, EventArgs e)
        {
            // If an itemnis selected
            if (studentList.SelectedIndex != -1)
            {
                if (currentMode == Mode.Students)
                {
                    clearSecondaryChart();

                    string tempStudentName = "";

                    // Get the student name
                    tempStudentName = studentList.SelectedItem.ToString();
                    tempStudentName = tempStudentName.Remove(tempStudentName.IndexOf(':'));

                    // Go through every transaction for every instrument
                    foreach (Instrument instrument in Form1.allInstruments)
                        foreach (Checkout transaction in instrument.checkouts)
                        {
                            DateTime tempDate = DateTime.Parse(transaction.date);

                            if ((tempDate >= backLimit) && (tempDate <= frontLimit))
                            {
                                if (transaction.sName == tempStudentName)
                                {
                                    if (transaction.type == Checkout.Type.checkin)
                                    {
                                        // If that type of transaction isn't contained, add it
                                        if (!studentCheckins.ContainsKey(transaction.sName))
                                        {
                                            var tempDict = new Dictionary<DateTime, int>();
                                            tempDict.Add(DateTime.Parse(transaction.date), 1);
                                            studentCheckins.Add(transaction.sName, tempDict);
                                        }
                                        else
                                        {
                                            // If the transaction does exists, but the date doesn't, add it
                                            if (!studentCheckins[transaction.sName].ContainsKey(DateTime.Parse(transaction.date)))
                                                studentCheckins[transaction.sName].Add(DateTime.Parse(transaction.date), 1);
                                            // Otherwise, increase the checkouts on that day by 1
                                            else
                                                studentCheckins[transaction.sName][DateTime.Parse(transaction.date)]++;
                                        }
                                    }
                                    // If it's a check-out
                                    else
                                    {
                                        // If that type of transaction isn't contained, add it
                                        if (!studentCheckouts.ContainsKey(transaction.sName))
                                        {
                                            var tempDict = new Dictionary<DateTime, int>();
                                            tempDict.Add(DateTime.Parse(transaction.date), 1);
                                            studentCheckouts.Add(transaction.sName, tempDict);
                                        }
                                        else
                                        {
                                            // If the transaction does exists, but the date doesn't, add it
                                            if (!studentCheckouts[transaction.sName].ContainsKey(DateTime.Parse(transaction.date)))
                                                studentCheckouts[transaction.sName].Add(DateTime.Parse(transaction.date), 1);
                                            // Otherwise, increase the checkouts on that day by 1
                                            else
                                                studentCheckouts[transaction.sName][DateTime.Parse(transaction.date)]++;
                                        }

                                    }
                                }
                            }
                        }

                    // Add the columns for a single student
                    lineChart.Series.Add("Checkins");
                    lineChart.Series["Checkins"].ChartType = SeriesChartType.Column;
                    lineChart.Series.Add("Checkouts");
                    lineChart.Series["Checkouts"].ChartType = SeriesChartType.Column;

                    // If there are any checkins, add them to the graph
                    if (studentCheckins.Count() != 0)
                        foreach (KeyValuePair<DateTime, int> transaction in studentCheckins[tempStudentName])
                            lineChart.Series["Checkins"].Points.AddXY(transaction.Key, transaction.Value);

                    // If there are any checkouts, add them to the graph
                    if (studentCheckouts.Count() != 0)
                        foreach (KeyValuePair<DateTime, int> transaction in studentCheckouts[tempStudentName])
                            lineChart.Series["Checkouts"].Points.AddXY(transaction.Key, transaction.Value);
                }
                else if (currentMode == Mode.Instruments)
                {
                    clearSecondaryChart();

                    // Get the instrument name
                    string tempInstrumentName = studentList.SelectedItem.ToString();
                    tempInstrumentName = tempInstrumentName.Remove(tempInstrumentName.IndexOf(':'));

                    Instrument currentInstrument = null;

                    // Find a matching instrument
                    foreach (Instrument instrument in Form1.allInstruments)
                        if (instrument.id == tempInstrumentName)
                        {
                            currentInstrument = instrument;
                            break;
                        }

                    if (currentInstrument != null)
                    {
                        // Set the instrument name
                        instrumentName = currentInstrument.name + ": " + tempInstrumentName;
                        foreach (Checkout checkout in currentInstrument.checkouts)
                        {
                            DateTime tempDate = DateTime.Parse(checkout.date);

                            if ((tempDate >= backLimit) && (tempDate <= frontLimit))
                            {
                                switch (checkout.type)
                                {
                                    case Checkout.Type.checkin:
                                        // Create date
                                        if (!instrumentCheckins.ContainsKey(tempDate))
                                            instrumentCheckins.Add(tempDate, 1);
                                        // Add 1 to date
                                        else
                                            instrumentCheckins[tempDate]++;
                                        break;

                                    case Checkout.Type.checkout:
                                        // Create date
                                        if (!instrumentCheckouts.ContainsKey(tempDate))
                                            instrumentCheckouts.Add(tempDate, 1);
                                        // Add 1 to date
                                        else
                                            instrumentCheckouts[tempDate]++;
                                        break;
                                }
                                checkoutStatusDisplay(currentInstrument);
                            }
                        }

                    }

                    // Add the columns for a single student
                    lineChart.Series.Add("Checkins");
                    lineChart.Series["Checkins"].ChartType = SeriesChartType.Column;
                    lineChart.Series.Add("Checkouts");
                    lineChart.Series["Checkouts"].ChartType = SeriesChartType.Column;

                    // Add the datapoints to the chart
                    if (instrumentCheckins.Count() != 0)
                        foreach (KeyValuePair<DateTime, int> transaction in instrumentCheckins)
                            lineChart.Series["Checkins"].Points.AddXY(transaction.Key, transaction.Value);

                    // Add the datapoints to the chart
                    if (instrumentCheckouts.Count() != 0)
                        foreach (KeyValuePair<DateTime, int> transaction in instrumentCheckouts)
                            lineChart.Series["Checkouts"].Points.AddXY(transaction.Key, transaction.Value);
                }
                else if (currentMode == Mode.Employees)
                {
                    clearSecondaryChart();

                    string tempEmployeeName = "";

                    tempEmployeeName = studentList.SelectedItem.ToString();
                    tempEmployeeName = tempEmployeeName.Remove(tempEmployeeName.IndexOf(':'));

                    // Go through every checkout for every instrument
                    foreach (Instrument instrument in Form1.allInstruments)
                        foreach (Checkout transaction in instrument.checkouts)
                        {
                            if (transaction.staff == tempEmployeeName)
                            {
                                DateTime tempDate = DateTime.Parse(transaction.date);

                                if((tempDate >= backLimit) && (tempDate <= frontLimit))
                                {
                                    // If there isn't already a key for that staff member, create it
                                    if (!employeeTransactions.ContainsKey(transaction.staff))
                                    {
                                        var tempDict = new Dictionary<DateTime, int>();
                                        tempDict.Add(tempDate, 1);
                                        employeeTransactions.Add(transaction.staff, tempDict);
                                    }
                                    else
                                    {
                                        // Add an entry for that staff member
                                        if (!employeeTransactions[transaction.staff].ContainsKey(tempDate))
                                            employeeTransactions[transaction.staff].Add(tempDate, 1);
                                        // Increase by 1
                                        else
                                            employeeTransactions[transaction.staff][tempDate]++;
                                    }
                                }
                            }
                        }

                    // Add the columns for a single student
                    lineChart.Series.Add("Transactions");
                    lineChart.Series["Transactions"].ChartType = SeriesChartType.Column;

                    // Add information to the chart
                    if (employeeTransactions.ContainsKey(tempEmployeeName) && employeeTransactions[tempEmployeeName].Count() != 0)
                    {
                        foreach (KeyValuePair<DateTime, int> transaction in employeeTransactions[tempEmployeeName])
                            lineChart.Series["Transactions"].Points.AddXY(transaction.Key, transaction.Value);
                    }

                    displaySecondaryGraphTitle(tempEmployeeName);
                }

                foreach (Series s in lineChart.Series)
                {
                    lineChart.Series[s.Name]["PixelPointWidth"] = "15";
                    if ((lineChart.Series.Count == 1) && (lineChart.Series[s.Name].Points.Count == 0))
                    {
                        lineChart.Series[s.Name].Points.AddXY("No Data\nAvailable", 0);
                    }
                }

                
            }
            
        }

        private void checkoutStatusDisplay(Instrument instrument)
        {
            var tempCheckoutList = from entry in instrument.checkouts orderby DateTime.Parse(entry.date) descending select entry;
            List<Checkout> finalList = new List<Checkout>();

            foreach (var item in tempCheckoutList)
                finalList.Add(item);

            string myText = "";

            switch (finalList[0].type)
            {
                case Checkout.Type.checkin:
                    myText = instrumentName + " - In";
                    break;
                case Checkout.Type.checkout:
                    myText = instrumentName + " - Out";
                    break;
            }

            displaySecondaryGraphTitle(myText);
        }

        private void displaySecondaryGraphTitle(string dText)
        {
            instrumentTitle.Location = new Point(
                (lineChart.Location.X + 50),
                instrumentTitle.Location.Y);

            instrumentTitle.Text = dText;
            instrumentTitle.Visible = true;
        }

        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(currentMode != Mode.Students)
            {
                currentMode = Mode.Students;
                perStudentSetup();
            }
        }

        private void employeeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMode != Mode.Employees)
            {
                currentMode = Mode.Employees;
                perEmployeeSetup();
            }
        }

        private void InstrumentRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMode != Mode.Instruments)
            {
                currentMode = Mode.Instruments;
                perInstrumentSetup();
            }
        }

        private void startCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (e.Start.CompareTo(frontLimit) <= 0)
            {
                backLimit = e.Start;
                refreshData();
            }
        }

        private void endCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(e.Start.CompareTo(backLimit) >= 0)
            {
                frontLimit = e.Start;
                refreshData();
            }
        }

        private void refreshData()
        {
            switch (currentMode)
            {
                case Mode.Instruments:
                    perInstrumentSetup();
                    break;
                case Mode.Students:
                    perStudentSetup();
                    break;
                case Mode.Employees:
                    perEmployeeSetup();
                    break;
                case Mode.perTime:
                    break;
            }
        }
    }
}
