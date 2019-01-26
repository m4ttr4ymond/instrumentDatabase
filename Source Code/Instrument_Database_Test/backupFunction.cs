using System;
using System.IO;
using System.IO.Compression;

namespace Instrument_Database_Test
{
    class backupFunction
    {
        // BACKUP PERFORMING

        // last backup date
        public static DateTime lastBackup = DateTime.Parse("1-1-2000");

        // Do the backup
        public static void performBackup(string filepath)
        {
            directoryCheck(filepath);
            readBackupTime(filepath);            
        }

        // Check to see if the holding directory exists
        static void directoryCheck(string fP)
        {
            // filepath for backups
            string filepath = fP + "\\Backups";

            if (!Directory.Exists(filepath))
                Directory.CreateDirectory(filepath);
        }

        // Finds the dae of the most recent backup
        static void readBackupTime(string filepath)
        {
            DateTime mostRecentBackup = DateTime.Parse("1/1/2000");

            // Checks to make sure the directory exists
            if (Directory.Exists(filepath + "\\Backups"))
            {
                // Temporary holder for the most recent date found yet
                DateTime temp = DateTime.Now;
                foreach (string backup in Directory.GetFiles(filepath + "\\Backups", "instrumentLibraryBackup-*.icrb"))
                {
                    // Pop date from filename
                    string temp1 = backup.Remove(backup.LastIndexOf(".")).Substring(backup.LastIndexOf("-") + 1);
                    string firstHalf = temp1.Remove(temp1.IndexOf("_")).Replace(".", "/");
                    string secondHalf = temp1.Substring(temp1.IndexOf("_") +1).Replace(".", ":").Replace("_", " ");
                    temp1 = firstHalf + " " + secondHalf;
                    if (DateTime.TryParse(temp1, out temp))

                        // If the new file is more recent than the one in temp
                        if (temp.CompareTo(mostRecentBackup) > 0)
                            mostRecentBackup = temp;
                }
            }

            // runs a backup if the backup date more than two weeks ago
            if (mostRecentBackup.AddDays(14).CompareTo(DateTime.Now) < 0)
                backupRun(filepath);
        }

        // Runs the backup
        public static void backupRun(string fP)
        {
            // New filepath for new backup
            string filepath = fP + "\\Backups\\instrumentLibraryBackup-" + DateTime.Now.ToShortDateString().Replace("/", ".") + "_" + DateTime.Now.ToLongTimeString().Replace(" ", "_").Replace(":", ".");
            Directory.CreateDirectory(filepath);

            // Copy all of the .xml files out of the "library data" directory and move them to a new file
            foreach (string file in Directory.GetFiles(fP, "*.xml"))
            {
                if (File.Exists(filepath + file.Substring(file.LastIndexOf("\\"))))
                    File.Delete(filepath + file.Substring(file.LastIndexOf("\\")));

                File.Copy(file, filepath + file.Substring(file.LastIndexOf("\\")));
            }

            // Zip that file
            ZipFile.CreateFromDirectory(filepath, filepath + ".icrb");

            // Delete the temporary files and directory
            foreach (string file in Directory.GetFiles(filepath))
                File.Delete(file);
            Directory.Delete(filepath);
        }

        //------------------------------------------------------//

        // BACKUP READING
        
        // Backs up from the newest backup
        public static void checkBackup(string fP)
        {
            string filepath = fP + "\\Backups";
            DateTime temp = DateTime.Now;
            string newestBackup = "";

            DateTime mostRecentBackup = DateTime.Parse("1/1/2000");

            // If there is a series of backups
            if (Directory.Exists(filepath))
            {

                // For each backup
                foreach (string file in Directory.GetFiles(filepath, "instrumentLibraryBackup-*.icrb"))
                {
                    // Temporary variable that holds the backup time information
                    string timeHolder = file.Remove(file.LastIndexOf(".")).Substring(file.LastIndexOf("_")+1);

                    // if it's a datetime
                    if (DateTime.TryParse(timeHolder, out temp))

                        // If it's more recent than the backup in temp
                        if (temp.CompareTo(mostRecentBackup) > 0)
                        {
                            mostRecentBackup = temp;
                            newestBackup = file;
                        }
                }

                // If there is a newest backup
                if (newestBackup != "")
                {
                    // Delete all of the data saved in the "Library Data" directory
                    foreach (string file in Directory.GetFiles(fP, "*.xml"))
                        File.Delete(file);

                    // Extract backed up files to there
                    ZipFile.ExtractToDirectory(newestBackup, fP);
                }
            }
        }
    }
}
