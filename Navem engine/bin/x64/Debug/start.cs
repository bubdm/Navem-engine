using System;
using System.Windows.Forms;
using Navem_engine;

namespace Navem_client
{
    class Program
    {
        static void Main(string[] args)
        {
            NavemWin window = new NavemEngine(new string[]{"$Width","$Height","$SizeMode","$Frame","$Title","$URL"}).Win;
                window.resizable(false);
                MenuMaker menus = new MenuMaker(window);
                menus.addMenuItem("btn1", "Menu", null);
				MenuMaker menus = new MenuMaker(menus.getMenu().Items.btn1);
                menus.addMenuItem("btn2", "Salir", salir);
                menus.show();
            window.App.run();
        }

        static void salir(object sender, EventArgs e)
        {
            NavemEngine.exit();
        }
    }
}