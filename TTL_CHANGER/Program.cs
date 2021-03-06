﻿using System;
using TTL_CHANGER;

namespace MOBILE_TTL_SCRIPT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Init();
        }
        static void Init()
        {
            Console.Clear();
            cmdText.printLogo();
            cmdText.PrintCommand("1", "SWITCH TTL TO 64 (MOBILE VALUE)");
            cmdText.PrintCommand("2", "SWITCH TTL TO 128(PC DEFAULT TTL)");
            cmdText.PrintCommand("3", "EXIT");
            //На заметку: параметр true не позволяет печатать текст во время регистрации нажатий
            ConsoleKeyInfo answer = Console.ReadKey(true);

            while(answer.KeyChar != 49 && answer.KeyChar != 50 && answer.KeyChar != 51)
            {
                answer = Console.ReadKey(true);
            }

            //1
            if (answer.KeyChar == 49) 
            {
                TTL.SetMobileTTL();
                cmdText.Done();
                RebootRequirement();               
            }
            //2
            else if (answer.KeyChar == 50) 
            {
                TTL.SetToDefault();
                cmdText.Done();
                RebootRequirement();
            }
            //3
            else if (answer.KeyChar == 51) 
            {
                Environment.Exit(0);
            };            
        }     
        
        public static void RebootRequirement()
        {
            cmdText.PrintRebootRequirement();
            ConsoleKeyInfo reboot = Console.ReadKey(true);
                        
            //ConsoleKey.Y
            while ((reboot.Key != ConsoleKey.Y) && (reboot.Key != ConsoleKey.N)) 
            {                
                reboot = Console.ReadKey(true);
            }                   

            if (reboot.Key == ConsoleKey.Y)
            {
                //PC Reboot                
                System.Diagnostics.Process.Start("shutdown", "/r /t 00");
            }
            else if(reboot.Key == ConsoleKey.N)
            {
                //App Loop                
                Init();
            }
                
        }
        
    }
}
