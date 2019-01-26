using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Instrument_Database_Test
{
    // Winform for exporting to a csv file
    class csvExporter
    {
        // Contains all of the code for this class
        public static void export(string filepath)
        {
            // List of all instruments
            List<Instrument> holderList = new List<Instrument>();

            // Add all instruments to the holderlist in sorted order
            foreach (BindingList<Instrument> list in Form1.libraryRecords)
                if (list != null)
                    holderList.AddRange(list.OrderBy(x => x.id).ToList());
            

            // Filepath for export
            //string filepath = Form1.filepath + "\\exportedLibrary.csv";

            // Delete previous file in filepath if it exists
            try
            {
                File.Delete(filepath);
            }
            catch (Exception)
            {
                // Skips the rest because there's no point in going on if this doesn't work
                goto END;
            }

            StringBuilder csvContent = new StringBuilder();

            // Main header for csv file
            string mainHeader = "Catagory,Cabinate,Name,Chapman ID #,Bow #,Brand,Model,Vendor,Serial #,Value,Status,Notes,";

            // Transaction header
            string checkoutFiller = "In/Out,Name,ID,Email,Date,Staff,Semester,Notes";

            int checkoutNumber = 0;

            // Figures out the max number of transactions in the file
            foreach (Instrument instrument in holderList)
                if (instrument.checkouts.Count > checkoutNumber)
                    checkoutNumber = instrument.checkouts.Count;

            // Initialize transaction header
            string checkoutList = "Transaction 1," + checkoutFiller;

            // For every other checkout, add to the header
            for (int i = 2; i <= checkoutNumber; i++)
                checkoutList += "," + "Transaction " + i.ToString() + "," + checkoutFiller;

            // Add to csv being built
            csvContent.AppendLine(mainHeader + checkoutList);

            foreach (Instrument instrument in holderList)
            {
                string tempIString;

                // Replace char to prevent the note from messing up the csv file
                string iNote = instrument.note.Replace('\n', ' ').Replace(',', ' ');

                // Create string with data
                tempIString = instrument.type.ToString() + "," +
                              instrument.cabinate + "," +
                              instrument.name + "," +
                              instrument.id + "," +
                              instrument.bow + "," +
                              instrument.brand + "," +
                              instrument.model + "," +
                              instrument.vendor + "," +
                              instrument.serialNumber + "," +
                              instrument.value + "," +
                              instrument.status.ToString() + "," +
                              iNote;
                // Append transaction data to tempIString
                foreach (Checkout checkout in instrument.checkouts)
                {
                    // Replace char to prevent the note from messing up the csv file
                    string qNote = checkout.note.content.Replace('\n', ' ').Replace(',', ' ');

                    // Create string with data
                    tempIString += ",," + checkout.type.ToString() + "," +
                                         checkout.sName + "," +
                                         checkout.sID.ToString() + "," +
                                         checkout.emailAddress + "," +
                                         checkout.date + "," +
                                         checkout.staff + "," +
                                         checkout.semester + "," +
                                         qNote;
                }
                // Add to cell
                csvContent.AppendLine(tempIString);
            }
            try
            {
                // Write to the file
                File.AppendAllText(filepath, csvContent.ToString());
            }
            catch (Exception)
            {
                // Error message
                notificationForm not = new notificationForm("There was an error with permissions on your computer\n" +
                                                            "We were not able to write to the file because we\n" +
                                                            "didn't have permission to access it");

                not.ShowDialog();
            }
        END:;
        }
    }
}
