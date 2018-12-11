using System;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // This winform creates a graph that shows what da pf the week is the most popular for checkouts
    public partial class MostPopularDay : Form
    {
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

        // Constructor
        public MostPopularDay()
        {
            InitializeComponent();
            populateDayChart();
        }

        // Fills the graph with information for which day is most popular
        private void populateDayChart()
        {
            // Legend
            string title = "Instruments/Day\nAverage";

            // Array for holding checkouts per day of the week
            int[] dotw = new int[7];

            DayOfWeek[] ordered = { 0, (DayOfWeek)1, (DayOfWeek)2, (DayOfWeek)3, (DayOfWeek)4, (DayOfWeek)5, (DayOfWeek)6 };

            // Looks through all of the instruments and cehckouts and saves them to the appropriate spot in the array
            foreach (Instrument instrument in Form1.allInstruments)
                foreach (Checkout transaction in instrument.checkouts)
                    dotw[((int)DateTime.Parse(transaction.date).DayOfWeek + 6) % 7]++;

            // Formatting
            dayChart.Series.Add(title);
            dayChart.Series[title].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            dayChart.Series[title].BorderWidth = 4;
            dayLabel.Text = "Monday:....... " + dotw[0] + "\n" +
                            "Tuesday:...... " + dotw[1] + "\n" +
                            "Wednesday:. " + dotw[2] + "\n" +
                            "Thursday:..... " + dotw[3] + "\n" +
                            "Friday:.......... " + dotw[4] + "\n" +
                            "Saturday:...... " + dotw[5] + "\n" +
                             "Sunday:........ " + dotw[6];

            // Populating the dataset
            dayChart.Series[title].Points.AddXY("Mon", dotw[0]);
            dayChart.Series[title].Points.AddXY("Tues", dotw[1]);
            dayChart.Series[title].Points.AddXY("Wed", dotw[2]);
            dayChart.Series[title].Points.AddXY("Thurs", dotw[3]);
            dayChart.Series[title].Points.AddXY("Fri", dotw[4]);
            dayChart.Series[title].Points.AddXY("Sat", dotw[5]);
            dayChart.Series[title].Points.AddXY("Sun", dotw[6]);

            // Sort the days of the week based on the number of checkouts
            Array.Sort(dotw, ordered);

            // Arrange them by descending
            Array.Reverse(ordered);
            Array.Reverse(dotw);

            string displayText = "";

            // Ranking
            int number = 1;

            // for every day of the week
            for (int i = 0; i < 7; i++)
            {
                // Add the day to the raking
                displayText += number + ": " + ((DayOfWeek)ordered[i]).ToString();

                // In case there's a tie, it puts multiple days of the week on the save line
                while (i < 6 && dotw[i] == dotw[i+1])
                {
                    i++;
                    displayText += "/" + ((DayOfWeek)ordered[i]);
                }
                displayText += "\n";
                number++;
            }

            // Display the ranking
            rankingLabel.Text = displayText;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
