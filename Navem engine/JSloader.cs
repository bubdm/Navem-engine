using CefSharp;
using CefSharp.WinForms;

namespace Navem_engine
{
    public class JSloader
    {
        private NavemWin window;
        private ChromiumWebBrowser browser;

        public JSloader(NavemWin window)
        {
            this.window = window;
            browser = window.getBrowser();
        }

        public void FrameLoadEnd(string code)
        {
            browser.FrameLoadEnd += (sender, args) =>
            {
                if (args.Frame.IsMain)
                {
                    args.Frame.ExecuteJavaScriptAsync(code);
                }
            };
        }

        public void LoadingStateChanged(string code)
        {
            browser.LoadingStateChanged += (sender, args) =>
            {
                if (args.IsLoading == false)
                {
                    browser.ExecuteScriptAsync(code);
                }
            };
        }

        public void AddLocalHandler(string name, object obj)
        {
            browser.RegisterJsObject(name, obj);
        }
    }
}
