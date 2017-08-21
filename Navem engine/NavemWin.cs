using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navem_engine
{
    public class NavemWin
    {
        private Form1 ventana;

        public NavemWin(string[] args)
        {
            int width = int.Parse(args[0]);
            int height = int.Parse(args[1]);
            string sizemode = args[2];
            bool frame = bool.Parse(args[3]);
            string name = args[4];
            string url = args[5];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ventana = new Form1(width, height, sizemode, frame, name, url);
            Application.Run(ventana);
        }
    }
}
