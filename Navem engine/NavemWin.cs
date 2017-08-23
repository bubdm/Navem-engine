using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;
using System.IO;

namespace Navem_engine
{
    public partial class NavemWin : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public NavemWin(int width, int height, string sizemode, bool frame, string name, string url)
        {
            InitializeComponent();
            InitializeChromium(url);
            Text = name;
            Size = new System.Drawing.Size(width, height);
            if (!frame)
                FormBorderStyle = FormBorderStyle.None;
            switch (sizemode.ToLower())
            {
                case "maximized":
                    WindowState = FormWindowState.Maximized;
                    break;
                case "minimized":
                    WindowState = FormWindowState.Minimized;
                    break;
                default:
                    WindowState = FormWindowState.Normal;
                    break;
            }
            if (File.Exists("build.ico"))
                Icon = new System.Drawing.Icon("build.ico");
        }

        private void InitializeChromium(string url)
        {
            CefSettings settings = new CefSettings();
            settings.Locale = "es-ES";
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser(url);
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void NavemWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        public void resizable(bool resize)
        {
            if (resize)
            {
                MaximumSize = new System.Drawing.Size(0, 0);
                MinimumSize = new System.Drawing.Size(0, 0);
            }
            else
            {
                MaximumSize = Size;
                MinimumSize = Size;
            }
        }

    }
}
