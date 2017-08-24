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
            menu(window);
			//jscript(window);
			window.resizable(true);
            window.App.run();
        }
		
		static void menu(NavemWin window)
		{
			MenuMaker menus = new MenuMaker(window);
				menus.addMenuItem("btn1", "Menu", null);
				ItemMaker sub01 = new ItemMaker(menus, "btn1");
					sub01.addSubItem("btn2", "Salir", salir);
			menus.show();
		}
		
		static void jscript(NavemWin window)
		{
			JSloader embed = new JSloader(window);
			embed.AddLocalHandler("win",new Program());
			embed.FrameLoadEnd(@"
             document.body.onmouseup = function()
             {
               win.msg('Pagina cargada correctamente');
             }
            ");
		}
		
		public void msg(string msg)
        {
            MessageBox.Show(msg);
        }
		
        public static void salir(object sender, EventArgs e)
        {
            NavemEngine.exit();
        }
    }
}