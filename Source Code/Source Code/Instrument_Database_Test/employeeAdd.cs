using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform for adding/deleting an employee
    public partial class employeeAdd : Form
    {
        // Variable for original list of employees
        BindingList<Employees> original;

        // What action to do on close
        int action;

        // Whether the user created a password
        public static bool passwordCreated = false;

        // "Constructor"
        public employeeAdd(int i)
        {
            InitializeComponent();
            action = i;
            // Copies from currentStaff
            original = Form1.currentStaff;
            // Populates the box
            employeeBox.DataSource = Form1.currentStaff.OrderBy(x => x.eName.Substring(x.eName.LastIndexOf(" ") + 1)).ToList<Employees>();

            // Prompts an employee name
            switch (action)
            {
                case 0:
                    nameBox.ForeColor = Color.Gray;
                    nameBox.Text = "Enter an employee name";
                    Refresh();
                    break;
            }

            if (Form1.currentStaff.Count < 1)
                this.adminButton.Select();
            else
                standardButton.Checked = true;

            Refresh();
        }

        // Adds an employee name to the list
        private void addButton_Click(object sender, EventArgs e)
        {
            passwordCreated = false;
            if (original.Count > 0 | adminButton.Checked)
            {
                if (nameBox.Text != "" && nameBox.Text != "Enter an employee name")
                {
                    // Capitalize the name
                    nameBox.Text = Checkout_Data.capitalizeName(nameBox.Text);
                    Employees temp = new Employees(nameBox.Text);
                    if (adminButton.Checked)
                    {
                        AddPassword aP = new AddPassword(temp);
                        aP.ShowDialog();
                    }
                    else
                    {
                        passwordCreated = true;
                    }
                    // Add new employee to the list
                    if (passwordCreated)
                        Form1.currentStaff.Add(temp);

                    passwordCreated = false;

                    nameBox.Text = "";
                    // Sort datasource
                    employeeBox.DataSource = Form1.currentStaff.OrderBy(x => x.eName.Substring(x.eName.LastIndexOf(" ") + 1))
                                             .ToList<Employees>();
                    Refresh();
                }
            }
            else
            {
                notificationForm nF = new notificationForm("You have to create an admin account\nbefore leaving this screen.");
                nF.ShowDialog();
            }

        }

        // Saves the new list to file
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Saves currentStaff to original, so that original can be saved to the list later
            if (Form1.currentStaff.Count > 0)
            {
                original = Form1.currentStaff;
                Close();
            }
        }

        // Close when cancel button is pushed
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if(original.Count > 0)
                Close();
        }

        // Delete the given employee from the list
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeBox.SelectedIndex >= 0 && employeeBox.SelectedItem != Form1.currentEmployee)
            {
                // Remove selected employee
                Form1.currentStaff.Remove((Employees) employeeBox.SelectedItem);
                // Refresh view
                employeeBox.DataSource = Form1.currentStaff;
                Refresh();
            }
        }

        // Saves when the form closes
        private void employeeAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.currentStaff = original;
            SaveToFile.serializeAll();

            if (action == 1 && Form1.currentStaff.Count > 0)
                {
                    employeeSelect eS = new employeeSelect();
                    eS.ShowDialog();
                }
        }

        // Change the hint text
        private void nameBox_Click(object sender, EventArgs e)
        {
            if(nameBox.Text == "Enter an employee name")
            {
                nameBox.ForeColor = Color.Black;
                nameBox.Text = "";
            }
        }

        // When enter is pressed
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If key == enter
            if (e.KeyChar == (char)13)
            {
                string input = nameBox.Text;
                // Click the button
                addButton_Click(sender, e);

                // Select the recently added name
                foreach (var employee in Form1.currentStaff.OrderBy(x => x.eName.Substring(x.eName.LastIndexOf(" ") + 1)).ToList<Employees>())
                {
                    if (employee.eName.ToLower() == input.ToLower())
                    {
                        employeeBox.SetSelected(Form1.currentStaff.IndexOf(employee), true);
                        saveButton_Click(sender, e);
                    }
                }
            }
        }
    }
}
