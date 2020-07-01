using System;

namespace TTL_CHANGER
{
    public class cmdText
    {
        private static string programName = "TTL CHANGER v1.0";
        public static void printLogo()
        {
            Console.Title = programName;
            Console.WriteLine();
            Console.WriteLine("     ************************************");

            Console.Write("     **   ");
            PrintWithColor("#####", ConsoleColor.Red);
            Console.Write("     ");
            PrintWithColor("######", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("#####", ConsoleColor.Red);
            Console.Write("     ");
            Console.WriteLine("**");

            Console.Write("     **   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("  ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("    ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("       ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.WriteLine("   **");

            Console.Write("     **   ");
            PrintWithColor("#####", ConsoleColor.Red);
            Console.Write("     ");
            PrintWithColor("######", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.WriteLine("   **");

            Console.Write("     **   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("  ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("    ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("       ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.WriteLine("   **");

            Console.Write("     **   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("##", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("######", ConsoleColor.Red);
            Console.Write("   ");
            PrintWithColor("#####", ConsoleColor.Red);
            Console.WriteLine("     **");

            Console.WriteLine("     ************************************");
            Console.WriteLine($"               {programName}");
            Console.WriteLine();
        }

        public static void PrintCommand(string buttonName, string text)
        {
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("PRESS ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{buttonName}");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(".");
            Console.ResetColor();
            Console.WriteLine(" - " + text);
        }  
        
        public static void Done()
        {
            Console.WriteLine();
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;            
            Console.WriteLine("DONE");
            Console.ResetColor();
        }

        public static void PrintRebootRequirement()
        {
            Console.Write("     ");
            Console.Write("PC SHOULD BE REBOOTED. DO IT NOW? (");
            Console.ForegroundColor = ConsoleColor.Green;            
            Console.Write("Y");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("N");
            Console.ResetColor();
            Console.WriteLine(")?");            
        }

        private static void PrintWithColor(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }
    }
}
