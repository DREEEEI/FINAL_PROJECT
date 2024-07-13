using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT
{
    internal class ALLBeginningInventory
    {
        
        public static (int, int, int, int, int) PartyhatsBeginningInv()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PARTY HATS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int HWhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int HPhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CChats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int MDhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int LPhats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (HWhats, HPhats, CChats, MDhats, LPhats);
        }

        public static (int, int, int, int, int) TraymatsBeginningInv()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("TRAY MATS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int HWmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int HPmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int MDmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int LPmats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (HWmats, HPmats, CCmats, MDmats, LPmats);
        }

        public static (int, int, int, int, int) GameprizesBeginningInv()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME PRIZES:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int HWprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int HPprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int MDprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int LPprize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (HWprize, HPprize, CCprize, MDprize, LPprize);
        }

        public static (int, int, int, int, int) GiveawaysBeginningInv()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("GIVEAWAYS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int HWgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int HPgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int MDgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int LPgive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (HWgive, HPgive, CCgive, MDgive, LPgive);
        }

        public static (int, int, int, int, int) GiftsBeginningInv()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("GIFTS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int HWgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int HPgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int MDgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int LPgift = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (HWgift, HPgift, CCgift, MDgift, LPgift);
        }
        
    }
}
