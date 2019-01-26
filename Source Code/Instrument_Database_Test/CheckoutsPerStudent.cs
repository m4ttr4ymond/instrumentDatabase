using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // This form displays the number of checkouts per student and ranks them from most to least checkouts
    public partial class CheckoutsPerStudent : Form
    {
        // Student data holders
        Dictionary<string, int> students = new Dictionary<string, int>();
        List<KeyValuePair<string, int>> sortedStudents = new List<KeyValuePair<string, int>>();

        // Constructor
        public CheckoutsPerStudent()
        {
            InitializeComponent();

            // Set up
            loadInfo();
            populateChart();
            populateOthers();
        }

        // Get the data for each student from the memory
        private void loadInfo()
        {
            foreach (Instrument instrument in Form1.allInstruments)
                foreach (Checkout transaction in instrument.checkouts)
                    if (transaction.type == (Checkout.Type)1)
                        if (!students.ContainsKey(transaction.sName))
                            students.Add(transaction.sName, 1);
                        else
                            students[transaction.sName]++;
        }

        // Fills the chart with the information
        private void populateChart()
        {
            // Formatting
            string title = "Checkouts/Student";
            checkoutChart.Series.Add(title);
            checkoutChart.Series[title].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            // order based on checkouts
            IOrderedEnumerable<KeyValuePair<string, int>> tempSort = from entry in students orderby entry.Value ascending select entry;

            foreach (KeyValuePair<string, int> item in tempSort)
                sortedStudents.Add(item);

            // Adds students to chart
            foreach (KeyValuePair<string, int> student in sortedStudents)
                checkoutChart.Series[title].Points.AddXY(student.Key, student.Value);

            // Sort students based on the number of checkouts they have
            tempSort = from entry in students orderby entry.Value descending select entry;

            // Add the students to the list to be displayed
            sortedStudents.Clear();
            foreach (KeyValuePair<string, int> item in tempSort)
                sortedStudents.Add(item);
        }

        // Populate the side chart
        private void populateOthers()
        {
            // String of students
            BindingList<string> stringStudents = new BindingList<string>();

            // Add person and the number of things that they checked out
            foreach (KeyValuePair<string, int> student in sortedStudents)
                stringStudents.Add(student.Key + ": " + student.Value);

            studentList.DataSource = stringStudents;
        }

        // Open student data if the student is double-clicked
        private void studentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string name = studentList.SelectedItem.ToString();
            name = name.Remove(name.LastIndexOf(":"));
            
            // Open new student log
            checkOutInLog log = new checkOutInLog(name);
            log.Show();
        }
    }
}
