using System;
using System.Windows.Forms;

namespace Refaccionaria
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm()); // Asegúrate de que este es tu formulario principal
        }
    }
}
