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
				ItemMaker sub01 = new ItemMaker(menus, "btn1");
					sub01.addSubItem("btn2", "Salir", salir);
				menus.show();
            window.App.run();
        }

        static void salir(object sender, EventArgs e)
        {
            NavemEngine.exit();
        }
    }
}