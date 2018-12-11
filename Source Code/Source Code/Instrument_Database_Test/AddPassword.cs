using System;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Form for adding a password to an admin account
    public partial class AddPassword : Form
    {
        Employees currentEmployee;

        // Constructor
        public AddPassword(Employees employee)
        {
            InitializeComponent();
            currentEmployee = employee;
        }

        // When the enter button is clicked
        private void enterButton_Click(object sender, EventArgs e)
        {
            currentEmployee.password = PasswordForm.sha256(passwordBox.Text);
            employeeAdd.passwordCreated = true;
            this.Close();
        }

        // Allows the user to press enter
        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
                enterButton_Click(sender, e);
        }
    }
}
