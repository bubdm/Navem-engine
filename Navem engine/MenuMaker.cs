using System;
using System.Drawing;
using System.Windows.Forms;

namespace Navem_engine
{
    public class MenuMaker
    {
        private MenuStrip menu = null;

        public MenuMaker(NavemWin window)
        {
            menu = window.getMenu();
        }

        public void show()
        {
            menu.Show();
        }

        public void hide()
        {
            menu.Hide();
        }

        public MenuStrip getMenu()
        {
            return menu;
        }

        public void addMenuItem(string name, string text, EventHandler handler)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text, null, handler, name);
            menu.Items.Add(item);
        }

        public void addMenuItem(string name, string text, EventHandler handler, string path)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text, new Bitmap(path), handler, text);
            menu.Items.Add(item);
        }
    }
}
