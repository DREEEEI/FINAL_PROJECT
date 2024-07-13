using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT
{
    internal class ALLConsumed
    {

        public static (int, int, int, int, int) PartyhatsConsumed()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PARTY HATS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int CHWhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int CHPhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCChats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int CMDhats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int CLPhats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (CHWhats, CHPhats, CCChats, CMDhats, CLPhats);
        }

        public static (int, int, int, int, int) TraymatsConsumed()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("TRAY MATS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int CHWmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int CHPmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCCmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int CMDmats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int CLPmats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (CHWmats, CHPmats, CCCmats, CMDmats, CLPmats);
        }

        public static (int, int, int, int, int) GameprizesConsumed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME PRIZES:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int CHWprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int CHPprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCCprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int CMDprize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int CLPprize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (CHWprize, CHPprize, CCCprize, CMDprize, CLPprize);
        }

        public static (int, int, int, int, int) GiveawaysConsumed()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("GIVEAWAYS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int CHWgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int CHPgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCCgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int CMDgive = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int CLPgive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (CHWgive, CHPgive, CCCgive, CMDgive, CLPgive);
        }

        public static (int, int, int, int, int) GiftsConsumed()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("GIFTS:");
            Console.ResetColor();
            Console.Write("Hotwheels: ");
            int CHWgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Happy: ");
            int CHPgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cocomelon: ");
            int CCCgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Madagascar: ");
            int CMDgift = Convert.ToInt32(Console.ReadLine());
            Console.Write("Little Pony: ");
            int CLPgift = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return (CHWgift, CHPgift, CCCgift, CMDgift, CLPgift);
        }
    }
}
