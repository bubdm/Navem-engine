using System.Diagnostics;

namespace Navem
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "client":
                    Process.Start("Navem client.exe");
                    break;

                case "run":
                    Process.Start("Navem run.exe", string.Join("\" \"",args).Substring(5) + "\"");
                    break;

                default:
                    break;
            }
        }
    }
}
