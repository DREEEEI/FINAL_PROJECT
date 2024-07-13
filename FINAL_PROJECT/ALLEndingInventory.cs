using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT
{
    internal class ALLEndingInventory
    {
        public static (int, int, int, int, int) PartyhatsEndingInv()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PARTY HATS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int EHWhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int EHPhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int ECChats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int EMDhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int ELPhats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (EHWhats, EHPhats, ECChats, EMDhats, ELPhats);
        }

        public static (int, int, int, int, int) TraymatsEndingInv()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("TRAY MATS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int EHWmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int EHPmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int ECCmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int EMDmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int ELPmats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (EHWmats, EHPmats, ECCmats, EMDmats, ELPmats);
        }

        public static (int, int, int, int, int) GameprizesEndingInv()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME PRIZES:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int EHWprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int EHPprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int ECCprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int EMDprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int ELPprize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (EHWprize, EHPprize, ECCprize, EMDprize, ELPprize);
        }

        public static (int, int, int, int, int) GiveawaysEndingInv()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("GIVEAWAYS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int EHWgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int EHPgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int ECCgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int EMDgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int ELPgive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (EHWgive, EHPgive, ECCgive, EMDgive, ELPgive);
        }

        public static (int, int, int, int, int) GiftsEndingInv()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("GIFTS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int EHWgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int EHPgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int ECCgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int EMDgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int ELPgift = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (EHWgift, EHPgift, ECCgift, EMDgift, ELPgift);
        }
    }
}
