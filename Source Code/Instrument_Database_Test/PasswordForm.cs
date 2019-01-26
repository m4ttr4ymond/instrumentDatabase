using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // This winform allows the user to enter a assword
    public partial class PasswordForm : Form
    {
        // The currently selected employee
        Employees currentEmployee;

        // Constructor
        public PasswordForm(Employees user)
        {
            InitializeComponent();
            currentEmployee = user;
            header.Text = "Enter a password to log in " + currentEmployee.eName;
            passwordBox.UseSystemPasswordChar = true;
            errorLabel.Text = "";
        }

        // Hashes the password to sha 256
        public static string sha256(string randomString)
        {
            // Creates a new SHA256Managed object
            SHA256Managed crypt = new SHA256Managed();

            // Encrypt
            string hash = "";
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte myByte in crypto)
                hash += myByte.ToString("x2");
            
            return hash;
        }

        // Clicking the enter button
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee.password == sha256(passwordBox.Text))
            {
                // Return true
                employeeSelect.passwordCorrect = true;
                this.Close();
            }
            else
            {
                // Give an error message
                Height = 281;
                errorLabel.Text = "Password is incorrect";
            }
        }

        // Cancel
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Allows enter to be pressed to enter the password
        private void PasswordForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                enterButton_Click(sender, e);
            }
        }
    }
}
