using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navem_engine
{
    public class ItemMaker
    {
        private ToolStripMenuItem submenu;

        public ItemMaker(ToolStripMenuItem submenu)
        {
            this.submenu = submenu;
        }

        public ItemMaker(MenuMaker menu, string name)
        {
            MenuStrip m = menu.getMenu();
            foreach (ToolStripMenuItem s in m.Items)
                if (s.Name == name)
                    submenu = s;
        }

        public ToolStripMenuItem GetItem()
        {
            return submenu;
        }

        public void addSubItem(string name, string text, EventHandler handler)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text, null, handler, text);
            submenu.DropDownItems.Add(item);
        }

        public void addSubItem(string name, string text, EventHandler handler, string path)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text, new Bitmap(path), handler, text);
            submenu.DropDownItems.Add(item);
        }
    }
}
