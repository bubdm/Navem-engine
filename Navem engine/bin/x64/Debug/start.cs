using Navem_engine;

namespace Navem_client
{
    class Program
    {
        static void Main(string[] args)
        {
            NavemEngine app = new NavemEngine(new string[]{"$Width","$Height","$SizeMode","$Frame","$Title","$URL"});
            NavemWin window = app.Win;
            window.resizable(false);
            app.run();
        }
    }
}