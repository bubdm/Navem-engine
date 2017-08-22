using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navem_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("FileName: ");
            string filename = Console.ReadLine();
            Console.Write("Set Width: ");
            string width = Console.ReadLine();
            Console.Write("Set Height: ");
            string height = Console.ReadLine();
            Console.Write("Set Sizemode: ");
            string sizemode = Console.ReadLine();
            Console.Write("Set Frame: ");
            string frame = Console.ReadLine();
            Console.Write("Set Title: ");
            string name = Console.ReadLine();
            Console.Write("Set URL: ");
            string url = Console.ReadLine();
            string icon = "";
            if (File.Exists("build.ico"))
                icon = " /win32icon:build.ico ";
            if (filename.EndsWith(".exe"))
                filename = " /out:" + filename + " ";
            else
                filename = " /out:" + filename + ".exe ";
            StreamReader str = new StreamReader("start.cs");
            string reed = str.ReadToEnd();
            str.Close();
            StreamWriter stw = new StreamWriter("start.cs");

            string repl = reed
                .Replace("$Width", width).Replace("$Height", height)
                .Replace("$SizeMode", sizemode).Replace("$Frame", frame)
                .Replace("$Title", name).Replace("$URL", url);

            stw.Write(repl);
            stw.Close();
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c csc " + " /target:winexe " + " \"/reference:Navem engine.dll\" " + icon + "\"" + filename + "\"" + "start.cs");
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            Console.ForegroundColor = ConsoleColor.Magenta;
            string result = proc.StandardOutput.ReadToEnd();
            Console.WriteLine(result);
            StreamWriter rtw = new StreamWriter("start.cs");
            rtw.Write(reed);
            rtw.Close();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
