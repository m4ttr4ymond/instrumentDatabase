using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Instrument_Database_Test
{
    // Winform for selecting the current employee
    public partial class employeeSelect : Form
    {
        // Bool for whether the password that was entered was correct
        public static bool passwordCorrect = false;

        // "Constructor"
        public employeeSelect()
        {
            InitializeComponent();

            // Set datasource
            employeeBox.DataSource = Form1.currentStaff.OrderBy(x => x.eName.Substring(x.eName.LastIndexOf(" ")+1))
                                         .ToList<Employees>();
            employeeBox.ClearSelected();

            try
            {
                // Select nothing
                employeeBox.SetSelected(Form1.currentStaff.Count - 1, true);
            }
            // If file is corrupted
            catch (Exception)
            {
                // Make new file
                File.Delete(Form1.filepath + "\\Employees.xml");
                File.Create(Form1.filepath + "\\Employees.xml");
            }
            
            Refresh();
        }

        // On double click, the form is closed, which triggers automatic selection
        private void selectItem_Click(object sender, EventArgs e)
        {
            Employees cE = (Employees)employeeBox.SelectedItem;

            // if the password is null, they don't need to log in
            if (cE.password == null)
                passwordCorrect = true;
            // Otherwise, check to see if their password is correct
            else
            {
                PasswordForm aP = new PasswordForm(cE);
                aP.ShowDialog();
            }

            // Only close if it is
            if(passwordCorrect)
                this.Close();
        }

        private void employeeSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If someone is selected
            if (employeeBox.SelectedIndex >= 0)
                // If the password is correct
                if(passwordCorrect)
                    // Set the current employee to the name that matchesthe one in the box
                    foreach (Employees employee in Form1.currentStaff)
                        if (employee.eName.Equals(employeeBox.SelectedItem.ToString()))
                        {
                            Form1.currentEmployee = employee;
                            break;
                        }
                    
            // Otherwise
            else
                // Set to a guest account
                Form1.currentEmployee = new Employees("Guest");
            passwordCorrect = false;
        }

        // If the user chooses "other"
        private void otherButton_Click(object sender, EventArgs e)
        {
            // Clear selection, which will default to "Other"
            employeeBox.ClearSelected();
            Close();
        }
    }
}
