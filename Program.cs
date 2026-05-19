using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace pulzz
{
    [SupportedOSPlatform("windows")]
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}
