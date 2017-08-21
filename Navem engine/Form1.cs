using System;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;
using System.IO;

namespace Navem_engine
{
    internal partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public Form1(int width, int height, string sizemode, bool frame, string name, string url)
        {
            InitializeComponent();
            InitializeChromium(url);
            Text = name;
            Size = new System.Drawing.Size(width, height);
            if(!frame)
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
            if(File.Exists("build.ico"))
                Icon = new System.Drawing.Icon("build.ico");
        }

        public void InitializeChromium(string url)
        {
            CefSettings settings = new CefSettings();
            settings.Locale = "es-ES";
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser(url);
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
