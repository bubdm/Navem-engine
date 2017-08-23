using System.Windows.Forms;

namespace Navem_engine
{
    public class NavemEngine
    {
        private NavemWin nwn;

        public NavemEngine(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Win = new NavemWin(int.Parse(args[0]), int.Parse(args[1]), args[2], bool.Parse(args[3]), args[4], args[5]);
        }

        public NavemWin Win { get => nwn; set => nwn = value; }

        public void run()
        {
            Application.Run(Win);
        }
    }
}
