using System;
using System.Windows.Forms;

namespace Instrument_Database_Test
{
    static class Program
    {
        // The main outline of the program
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
