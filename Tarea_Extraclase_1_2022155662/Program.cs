using System;
using System.Windows.Forms;

namespace Tarea_Extraclase_1_2022155662
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            string port = null;
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    if (arg.StartsWith("--port="))
                    {
                        port = arg.Substring("--port=".Length);
                    }
                }
            }
            
            Application.Run(new Form1(port));
        }
    }
}
