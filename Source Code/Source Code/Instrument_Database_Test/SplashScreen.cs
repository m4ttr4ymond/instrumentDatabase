using System.Threading;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    // This form shows a splash screen
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            Title.Text = "COPA Library";
            versionNumber.Text = Form1.versionNumber;
            this.Show();
            Refresh();
            Thread.Sleep(3000);
            Close();
        }
    }
}
