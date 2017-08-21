using Navem_engine;

namespace Navem_client
{
    class Program
    {
        static void Main(string[] args)
        {
            new NavemWin(new string[]{"$Width","$Height","$SizeMode","$Frame","$Title","$URL"});
        }
    }
}