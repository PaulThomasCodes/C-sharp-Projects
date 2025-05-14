using System;
using System.Windows.Forms;  // Make sure you have this using directive

namespace ClientSessionTracker
{
    static class Program
    {
        // The main entry point for the application
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Make sure Form1 is referenced here
        }
    }
}