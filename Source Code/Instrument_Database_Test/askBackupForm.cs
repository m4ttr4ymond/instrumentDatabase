using System;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Asks the user if they want to do the backup
    public partial class askBackupForm : Form
    {
        // Constructor
        public askBackupForm()
        {
            InitializeComponent();
        }

        // if they choose to contiue
        private void continueButton_Click(object sender, EventArgs e)
        {
            SaveToFile.backupStatus = true;
            Close();
        }

        // If they chose not to continue
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
