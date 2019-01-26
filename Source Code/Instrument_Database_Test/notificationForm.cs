using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // Winform that acts as a notification
    public partial class notificationForm : Form
    {
        // "Constructor" 1 - takes a staring string and an ending string
        public notificationForm(string start, string end)
        {
            InitializeComponent();
            
            // Writes a message telling what happened
            warningText.Text = "You have chenaged the record from \"" + start + "\" to \"" + end + "\"";
            resize();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        // "Constructor" 2 - takes a message to be displayed
        public notificationForm(string message)
        {
            InitializeComponent();
            warningText.Text = message;
            resize();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }
        
        // Resize the winform to fit all of the text
        private void resize()
        {
            int i = 0;
            this.Width = warningText.Width + 40;
            foreach (char character in warningText.Text)
                if (character == '\n')
                    i++;
            this.Height = i * 10 + 80;
        }
    }
}
