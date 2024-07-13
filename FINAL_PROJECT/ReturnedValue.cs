using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT
{
    internal class ReturnedValue
    {
        public static void AllInventory()
        {
            Trade.Mark();
            Console.WriteLine("WELCOME TO PARTY AMENITIES INVENTORY SYSTEM!\n");
            Console.WriteLine("PLEASE ENTER THE BEGINNING INVENTORY OF THE FOLLOWING: \n");
            int HWhats, HPhats, CChats, MDhats, LPhats;
            (HWhats, HPhats, CChats, MDhats, LPhats) = ALLBeginningInventory.PartyhatsBeginningInv();
            int HWmats, HPmats, CCmats, MDmats, LPmats;
            (HWmats, HPmats, CCmats, MDmats, LPmats) = ALLBeginningInventory.TraymatsBeginningInv();
            int HWprize, HPprize, CCprize, MDprize, LPprize;
            (HWprize, HPprize, CCprize, MDprize, LPprize) = ALLBeginningInventory.GameprizesBeginningInv();
            int HWgive, HPgive, CCgive, MDgive, LPgive;
            (HWgive, HPgive, CCgive, MDgive, LPgive) = ALLBeginningInventory.GiveawaysBeginningInv();
            int HWgift, HPgift, CCgift, MDgift, LPgift;
            (HWgift, HPgift, CCgift, MDgift, LPgift) = ALLBeginningInventory.GiftsBeginningInv();
            Console.ResetColor();

            Console.WriteLine("\nPress any key to proceed.");
            Console.ReadKey();
            Console.Clear();
            Trade.Mark();

            Console.WriteLine("NOW, PLEASE ENTER THE CONSUMED STOCKS OF THE FOLLOWING:\n");
            int CHWhats, CHPhats, CCChats, CMDhats, CLPhats;
            (CHWhats, CHPhats, CCChats, CMDhats, CLPhats) = ALLConsumed.PartyhatsConsumed();

            int CHWmats, CHPmats, CCCmats, CMDmats, CLPmats;
            (CHWmats, CHPmats, CCCmats, CMDmats, CLPmats) = ALLConsumed.TraymatsConsumed();

            int CHWprize, CHPprize, CCCprize, CMDprize, CLPprize;
            (CHWprize, CHPprize, CCCprize, CMDprize, CLPprize) = ALLConsumed.GameprizesConsumed();

            int CHWgive, CHPgive, CCCgive, CMDgive, CLPgive;
            (CHWgive, CHPgive, CCCgive, CMDgive, CLPgive) = ALLConsumed.GiveawaysConsumed();

            int CHWgift, CHPgift, CCCgift, CMDgift, CLPgift;
            (CHWgift, CHPgift, CCCgift, CMDgift, CLPgift) = ALLConsumed.GiftsConsumed();

            Console.WriteLine("\nPress any key to proceed.");
            Console.ReadKey();
            Console.Clear();
            Trade.Mark();

            int SBHWhats;
            SBHWhats = Calculations.ShouldBeHWhats(HWhats, CHWhats);
            int SBHPhats;
            SBHPhats = Calculations.ShouldBeHPhats(HPhats, CHPhats);
            int SBCChats;
            SBCChats = Calculations.ShouldBeCChats(CChats, CCChats);
            int SBMDhats;
            SBMDhats = Calculations.ShouldBeMDhats(MDhats, CMDhats);
            int SBLPhats;
            SBLPhats = Calculations.ShouldBeLPhats(LPhats, CLPhats);

            int SBHWmats;
            SBHWmats = Calculations.ShouldBeHWmats(HWmats, CHWmats);
            int SBHPmats;
            SBHPmats = Calculations.ShouldBeHPmats(HPmats, CHPmats);
            int SBCCmats;
            SBCCmats = Calculations.ShouldBeCCmats(CCmats, CCCmats);
            int SBMDmats;
            SBMDmats = Calculations.ShouldBeMDmats(MDmats, CMDmats);
            int SBLPmats;
            SBLPmats = Calculations.ShouldBeLPmats(LPmats, CLPmats);

            int SBHWprize;
            SBHWprize = Calculations.ShouldBeHWprize(HWprize, CHWprize);
            int SBHPprize;
            SBHPprize = Calculations.ShouldBeHPprize(HPprize, CHPprize);
            int SBCCprize;
            SBCCprize = Calculations.ShouldBeCCprize(CCprize, CCCprize);
            int SBMDprize;
            SBMDprize = Calculations.ShouldBeMDprize(MDprize, CMDprize);
            int SBLPprize;
            SBLPprize = Calculations.ShouldBeLPprize(LPprize, CLPprize);

            int SBHWgive;
            SBHWgive = Calculations.ShouldBeHWgive(HWgive, CHWgive);
            int SBHPgive;
            SBHPgive = Calculations.ShouldBeHPgive(HPgive, CHPgive);
            int SBCCgive;
            SBCCgive = Calculations.ShouldBeCCgive(CCgive, CCCgive);
            int SBMDgive;
            SBMDgive = Calculations.ShouldBeMDgive(MDgive, CMDgive);
            int SBLPgive;
            SBLPgive = Calculations.ShouldBeLPgive(LPgive, CLPgive);

            int SBHWgift;
            SBHWgift = Calculations.ShouldBeHWgift(HWgift, CHWgift);
            int SBHPgift;
            SBHPgift = Calculations.ShouldBeHPgift(HPgift, CHPgift);
            int SBCCgift;
            SBCCgift = Calculations.ShouldBeCCgift(CCgift, CCCgift);
            int SBMDgift;
            SBMDgift = Calculations.ShouldBeMDgift(MDgift, CMDgift);
            int SBLPgift;
            SBLPgift = Calculations.ShouldBeLPgift(LPgift, CLPgift);
            Console.WriteLine("\nPress any key to proceed.");
            Console.ReadKey();
            ; Console.Clear();

            Trade.Mark();
            Console.WriteLine("NOW, PLEASE ENTER THE ENDING INVENTORY OF THE FOLLOWING:\n");
            int EHWhats, EHPhats, ECChats, EMDhats, ELPhats;
            (EHWhats, EHPhats, ECChats, EMDhats, ELPhats) = ALLEndingInventory.PartyhatsEndingInv();

            int EHWmats, EHPmats, ECCmats, EMDmats, ELPmats;
            (EHWmats, EHPmats, ECCmats, EMDmats, ELPmats) = ALLEndingInventory.TraymatsEndingInv();

            int EHWprize, EHPprize, ECCprize, EMDprize, ELPprize;
            (EHWprize, EHPprize, ECCprize, EMDprize, ELPprize) = ALLEndingInventory.GameprizesEndingInv();

            int EHWgive, EHPgive, ECCgive, EMDgive, ELPgive;
            (EHWgive, EHPgive, ECCgive, EMDgive, ELPgive) = ALLEndingInventory.GiveawaysEndingInv();

            int EHWgift, EHPgift, ECCgift, EMDgift, ELPgift;
            (EHWgift, EHPgift, ECCgift, EMDgift, ELPgift) = ALLEndingInventory.GiftsEndingInv();

            Console.Clear();
            Trade.Mark();

            int VHWhats;
            VHWhats = Calculations.VarianceHWhats(SBHWhats, EHWhats);
            int VHPhats;
            VHPhats = Calculations.VarianceHPhats(SBHPhats, EHPhats);
            int VCChats;
            VCChats = Calculations.VarianceCChats(SBCChats, ECChats);
            int VMDhats;
            VMDhats = Calculations.VarianceMDhats(SBMDhats, EMDhats);
            int VLPhats;
            VLPhats = Calculations.VarianceLPhats(SBLPhats, ELPhats);

            int VHWmats;
            VHWmats = Calculations.VarianceHWmats(SBHWmats, EHWmats);
            int VHPmats;
            VHPmats = Calculations.VarianceHPmats(SBHPmats, EHPmats);
            int VCCmats;
            VCCmats = Calculations.VarianceCCmats(SBCCmats, ECCmats);
            int VMDmats;
            VMDmats = Calculations.VarianceMDmats(SBMDmats, EMDmats);
            int VLPmats;
            VLPmats = Calculations.VarianceLPmats(SBLPmats, ELPmats);

            int VHWprize;
            VHWprize = Calculations.VarianceHWprize(SBHWprize, EHWprize);
            int VHPprize;
            VHPprize = Calculations.VarianceHPprize(SBHPprize, EHPprize);
            int VCCprize;
            VCCprize = Calculations.VarianceCCprize(SBCCprize, ECCprize);
            int VMDprize;
            VMDprize = Calculations.VarianceMDprize(SBMDprize, EMDprize);
            int VLPprize;
            VLPprize = Calculations.VarianceLPprize(SBLPprize, ELPprize);

            int VHWgive;
            VHWgive = Calculations.VarianceHWgive(SBHWgive, EHWgive);
            int VHPgive;
            VHPgive = Calculations.VarianceHPgive(SBHPgive, EHPgive);
            int VCCgive;
            VCCgive = Calculations.VarianceCCgive(SBCCgive, ECCgive);
            int VMDgive;
            VMDgive = Calculations.VarianceMDgive(SBMDgive, EMDgive);
            int VLPgive;
            VLPgive = Calculations.VarianceLPgive(SBLPgive, ELPgive);

            int VHWgift;
            VHWgift = Calculations.VarianceHWgift(SBHWgift, EHWgift);
            int VHPgift;
            VHPgift = Calculations.VarianceHPgift(SBHPgift, EHPgift);
            int VCCgift;
            VCCgift = Calculations.VarianceCCgift(SBCCgift, ECCgift);
            int VMDgift;
            VMDgift = Calculations.VarianceMDgift(SBMDgift, EMDgift);
            int VLPgift;
            VLPgift = Calculations.VarianceLPgift(SBLPgift, ELPgift);

            Console.WriteLine("\nPress any key to proceed.");
            Console.ReadKey();
            Console.Clear();

        while (true)
            {
                int LoopExit = 0;

                Trade.Mark();
                Console.WriteLine("PLEASE SELECT THE FUNCTION YOU WANT TO EXECUTE:\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Summary of Report");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("2. Most Consumed Stocks");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3. Least Consumed Stocks");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("4. Highest Remaining Stocks");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("5. Lowest Remaining Stocks");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("6. Exit\n");
                Console.ResetColor();
                Console.Write("Enter Input (1/2/3/4/5/6): ");
                int function = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (function)
                {
                    case 1:
                        {
                            DataTable table = new DataTable("MySummaryReport");
                            table.Columns.Add("Theme", typeof(string));
                            table.Columns.Add("Beginning Inventory", typeof(int));
                            table.Columns.Add("Consumed", typeof(int));
                            table.Columns.Add("Should Be", typeof(int));
                            table.Columns.Add("Ending Inventory", typeof(int));
                            table.Columns.Add("Variance", typeof(int));

                            table.Rows.Add("HW Party Hats", HWhats, CHWhats, SBHWhats, EHWhats, VHWhats);
                            table.Rows.Add("HP Party Hats", HPhats, CHPhats, SBHPhats, EHPhats, VHPhats);
                            table.Rows.Add("CC Party Hats", CChats, CCChats, SBCChats, ECChats, VCChats);
                            table.Rows.Add("MD Party Hats", MDhats, CMDhats, SBMDhats, EMDhats, VMDhats);
                            table.Rows.Add("LP Party Hats", LPhats, CLPhats, SBLPhats, ELPhats, VLPhats);

                            table.Rows.Add("HW Traymats", HWmats, CHWmats, SBHWmats, EHWmats, VHWmats);
                            table.Rows.Add("HP Traymats", HPmats, CHPmats, SBHPmats, EHPmats, VHPmats);
                            table.Rows.Add("CC Traymats", CCmats, CCCmats, SBCCmats, ECCmats, VCCmats);
                            table.Rows.Add("MD Traymats", MDmats, CMDmats, SBMDmats, EMDmats, VMDmats);
                            table.Rows.Add("LP Traymats", LPmats, CLPmats, SBLPmats, ELPmats, VLPmats);

                            table.Rows.Add("HW Prizes", HWprize, CHWprize, SBHWprize, EHWprize, VHWprize);
                            table.Rows.Add("HP Prizes", HPprize, CHPprize, SBHPprize, EHPprize, VHPprize);
                            table.Rows.Add("CC Prizes", CCprize, CCCprize, SBCCprize, ECCprize, VCCprize);
                            table.Rows.Add("MD Prizes", MDprize, CMDprize, SBMDprize, EMDprize, VMDprize);
                            table.Rows.Add("LP Prizes", LPprize, CLPprize, SBLPprize, ELPprize, VLPprize);

                            table.Rows.Add("HW Giveaways", HWgive, CHWgive, SBHWgive, EHWgive, VHWgive);
                            table.Rows.Add("HP Giveaways", HPgive, CHPgive, SBHPgive, EHPgive, VHPgive);
                            table.Rows.Add("CC Giveaways", CCgive, CCCgive, SBCCgive, ECCgive, VCCgive);
                            table.Rows.Add("MD Giveaways", MDgive, CMDgive, SBMDgive, EMDgive, VMDgive);
                            table.Rows.Add("LP Giveaways", LPgive, CLPgive, SBLPgive, ELPgive, VLPgive);

                            table.Rows.Add("HW Gifts", HWgift, CHWgift, SBHWgift, EHWgift, VHWgift);
                            table.Rows.Add("HP Gifts", HPgift, CHPgift, SBHPgift, EHPgift, VHPgift);
                            table.Rows.Add("CC Gifts", CCgift, CCCgift, SBCCgift, ECCgift, VCCgift);
                            table.Rows.Add("MD Gifts", MDgift, CMDgift, SBMDgift, EMDgift, VMDgift);
                            table.Rows.Add("LP Gifts", LPgift, CLPgift, SBLPgift, ELPgift, VLPgift);

                            Console.WriteLine("                                ---- SUMMARY OF REPORT ----");

                            Console.WriteLine("LEGEND:");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("HW = Hotwheels");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("HP = Happy");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("CC = Cocomelon");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("MD = Madagascar");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("LP = Little Pony");
                            Console.ResetColor();

                            Console.WriteLine("-" + new string('-', 92));
                            Console.Write("{0, -15} {1, -15} {2, -15}", "   Theme", "Beginning", "Consumed");
                            Console.WriteLine("{0, -15} {1, -15} {2, -15}", "Should Be", "Ending", "Variance");
                            Console.WriteLine("                Inventory                                      Inventory");
                            Console.WriteLine("-" + new string('-', 92));

                            foreach (DataRow row in table.Rows)
                            {
                                Console.WriteLine("{0, -18} {1, -15} {2, -15} {3, -15} {4, -14} {5, -15}",
                                        row["Theme"], row["Beginning Inventory"], row["Consumed"], row["Should Be"],
                                        row["Ending Inventory"], row["Variance"]);
                                Console.WriteLine("");
                            }
                            Console.WriteLine("-" + new string('-', 92));
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        MostConsumedHats(CHWhats, CHPhats, CCChats, CMDhats, CLPhats);
                        MostConsumedMats(CHWmats, CHPmats, CCCmats, CMDmats, CLPmats);
                        MostConsumedPrizes(CHWprize, CHPprize, CCCprize, CMDprize, CLPprize);
                        MostConsumedGives(CHWgive, CHPgive, CCCgive, CMDgive, CLPgive);
                        MostConsumedGifts(CHWgift, CHPgift, CCCgift, CMDgift, CLPgift);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        LeastConsumedHats(CHWhats, CHPhats, CCChats, CMDhats, CLPhats);
                        LeastConsumedMats(CHWmats, CHPmats, CCCmats, CMDmats, CLPmats);
                        LeastConsumedPrizes(CHWprize, CHPprize, CCCprize, CMDprize, CLPprize);
                        LeastConsumedGives(CHWgive, CHPgive, CCCgive, CMDgive, CLPgive);
                        LeastConsumedGifts(CHWgift, CHPgift, CCCgift, CMDgift, CLPgift);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        HighestRemainingHats(EHWhats, EHPhats, ECChats, EMDhats, ELPhats);
                        HighestRemainingMats(EHWmats, EHPmats, ECCmats, EMDmats, ELPmats);
                        HighestRemainingPrizes(EHWprize, EHPprize, ECCprize, EMDprize, ELPprize);
                        HighestRemainingGives(EHWgive, EHPgive, ECCgive, EMDgive, ELPgive);
                        HighestRemainingGifts(EHWgift, EHPgift, ECCgift, EMDgift, ELPgift);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        LowestRemainingHats(EHWhats, EHPhats, ECChats, EMDhats, ELPhats);
                        LowestRemainingMats(EHWmats, EHPmats, ECCmats, EMDmats, ELPmats);
                        LowestRemainingPrizes(EHWprize, EHPprize, ECCprize, EMDprize, ELPprize);
                        LowestRemainingGives(EHWgive, EHPgive, ECCgive, EMDgive, ELPgive);
                        LowestRemainingGifts(EHWgift, EHPgift, ECCgift, EMDgift, ELPgift);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        LoopExit = 1;
                        Console.Clear();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Input!");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

                if (LoopExit != 0)
                {
                    break;
                }
            }                      
        }

        // HIGHEST CONSUMED FOR PARTY HATS
        public static void MostConsumedHats(int CHWmats, int CHPmats, int CCCmats, int CMDhats, int CLPhats)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR PARTY HATS IS ");

            int most = CHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPmats > most)
            {
                most = CHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPmats == most)
            {
                messages.Add("HAPPY");
            }

            if (CCCmats > most)
            {
                most = CCCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCmats == most)
            {
                messages.Add("COCOMELON");
            }

            if (CMDhats > most)
            {
                most = CMDhats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDhats == most)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPhats > most)
            {
                most = CLPhats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPhats == most)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {most} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST CONSUMED FOR PARTY TRAYMATSATS
        public static void MostConsumedMats(int CHWmats, int CHPmats, int CCCmats, int CMDmats, int CLPmats)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR PARTY TRAYMATS IS ");

            int most = CHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPmats > most)
            {
                most = CHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPmats == most)
            {
                messages.Add("HAPPY");
            }

            if (CCCmats > most)
            {
                most = CCCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCmats == most)
            {
                messages.Add("COCOMELON");
            }

            if (CMDmats > most)
            {
                most = CMDmats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDmats == most)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPmats > most)
            {
                most = CLPmats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPmats == most)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {most} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST CONSUMED FOR GAMEPRIZES
        public static void MostConsumedPrizes(int CHWprize, int CHPprize, int CCCprize, int CMDprize, int CLPprize)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR GAME PRIZES IS ");

            int most = CHWprize;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPprize > most)
            {
                most = CHPprize;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPprize == most)
            {
                messages.Add("HAPPY");
            }

            if (CCCprize > most)
            {
                most = CCCprize;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCprize == most)
            {
                messages.Add("COCOMELON");
            }

            if (CMDprize > most)
            {
                most = CMDprize;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDprize == most)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPprize > most)
            {
                most = CLPprize;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPprize == most)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {most} CASES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST CONSUMED FOR GIVEAWAYS
        public static void MostConsumedGives(int CHWgive, int CHPgive, int CCCgive, int CMDgive, int CLPgive)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR GIVEAWAYS IS ");

            int most = CHWgive;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPgive > most)
            {
                most = CHPgive;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPgive == most)
            {
                messages.Add("HAPPY");
            }

            if (CCCgive > most)
            {
                most = CCCgive;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCgive == most)
            {
                messages.Add("COCOMELON");
            }

            if (CMDgive > most)
            {
                most = CMDgive;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDgive == most)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPgive > most)
            {
                most = CLPgive;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPgive == most)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {most} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST CONSUMED FOR GIFTS
        public static void MostConsumedGifts(int CHWgift, int CHPgift, int CCCgift, int CMDgift, int CLPgift)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR GIFTS IS ");

            int most = CHWgift;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPgift > most)
            {
                most = CHPgift;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPgift == most)
            {
                messages.Add("HAPPY");
            }

            if (CCCgift > most)
            {
                most = CCCgift;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCgift == most)
            {
                messages.Add("COCOMELON");
            }

            if (CMDgift > most)
            {
                most = CMDgift;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDgift == most)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPgift > most)
            {
                most = CLPgift;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPgift == most)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {most} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LEAST CONSUMED FOR PARTY HATS
        public static void LeastConsumedHats(int CHWmats, int CHPmats, int CCCmats, int CMDhats, int CLPhats)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR PARTY HATS IS ");

            int lowest = CHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPmats < lowest)
            {
                lowest = CHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPmats == lowest)
            {
                messages.Add("HAPPY");
            }

            if (CCCmats < lowest)
            {
                lowest = CCCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCmats == lowest)
            {
                messages.Add("COCOMELON");
            }

            if (CMDhats < lowest)
            {
                lowest = CMDhats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDhats == lowest)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPhats < lowest)
            {
                lowest = CLPhats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPhats == lowest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {lowest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LEAST CONSUMED FOR PARTY TRAYMATS
        public static void LeastConsumedMats(int CHWmats, int CHPmats, int CCCmats, int CMDmats, int CLPmats)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR PARTY TRAYMATS IS ");

            int lowest = CHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPmats < lowest)
            {
                lowest = CHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPmats == lowest)
            {
                messages.Add("HAPPY");
            }

            if (CCCmats < lowest)
            {
                lowest = CCCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCmats == lowest)
            {
                messages.Add("COCOMELON");
            }

            if (CMDmats < lowest)
            {
                lowest = CMDmats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDmats == lowest)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPmats < lowest)
            {
                lowest = CLPmats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPmats == lowest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {lowest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST CONSUMED FOR GAME PRIZES
        public static void LeastConsumedPrizes(int EHWprize, int EHPprize, int ECCprize, int EMDprize, int ELPprize)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR GAME PRIZES IS ");

            int least = EHWprize;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPprize < least)
            {
                least = EHPprize;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPprize == least)
            {
                messages.Add("HAPPY");
            }

            if (ECCprize < least)
            {
                least = ECCprize;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCprize == least)
            {
                messages.Add("COCOMELON");
            }

            if (EMDprize < least)
            {
                least = EMDprize;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDprize == least)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPprize < least)
            {
                least = ELPprize;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPprize == least)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {least} CASES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LEAST CONSUMED FOR GIVEAWAYS
        public static void LeastConsumedGives(int CHWgive, int CHPgive, int CCCgive, int CMDgive, int CLPgive)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR GIVEAWAYS IS ");

            int least = CHWgive;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (CHPgive < least)
            {
                least = CHPgive;
                messages = new List<string> { "HAPPY" };
            }
            else if (CHPgive == least)
            {
                messages.Add("HAPPY");
            }

            if (CCCgive < least)
            {
                least = CCCgive;
                messages = new List<string> { "COCOMELON" };
            }
            else if (CCCgive == least)
            {
                messages.Add("COCOMELON");
            }

            if (CMDgive < least)
            {
                least = CMDgive;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (CMDgive == least)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPgive < least)
            {
                least = CLPgive;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (CLPgive == least)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {least} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LEAST CONSUMED FOR GIFTS
        public static void LeastConsumedGifts(int CHWgift, int CHPgift, int CCCgift, int CMDgift, int CLPgift)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR GIFTS IS ");

            int least = CHWgift;
            List<string> messages = new List<string> {"HOTWHEELS"};

            if (CHPgift < least)
            {
                least = CHPgift;
                messages = new List<string> {"HAPPY"};
            }
            else if (CHPgift == least)
            {
                messages.Add("HAPPY");
            }

            if (CCCgift < least)
            {
                least = CCCgift;
                messages = new List<string> {"COCOMELON"};
            }
            else if (CCCgift == least)
            {
                messages.Add("COCOMELON");
            }

            if (CMDgift < least)
            {
                least = CMDgift;
                messages = new List<string> {"MADAGASCAR"};
            }
            else if (CMDgift == least)
            {
                messages.Add("MADAGASCAR");
            }

            if (CLPgift < least)
            {
                least = CLPgift;
                messages = new List<string> {"LITTLE PONY"};
            }
            else if (CLPgift == least)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {least} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST REMAINING STOCKS FOR PARTY HATS
        public static void HighestRemainingHats(int EHWmats, int EHPmats, int ECCmats, int EMDhats, int ELPhats)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR PARTY HATS IS ");

            int highest = EHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPmats > highest)
            {
                highest = EHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPmats == highest)
            {
                messages.Add("HAPPY");
            }

            if (ECCmats > highest)
            {
                highest = ECCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCmats == highest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDhats > highest)
            {
                highest = EMDhats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDhats == highest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPhats > highest)
            {
                highest = ELPhats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPhats == highest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {highest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST REMAINING STOCKS FOR PARTY TRAYMATSATS
        public static void HighestRemainingMats(int EHWmats, int EHPmats, int ECCmats, int EMDmats, int ELPmats)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR PARTY TRAYMATS IS ");

            int highest = EHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPmats > highest)
            {
                highest = EHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPmats == highest)
            {
                messages.Add("HAPPY");
            }

            if (ECCmats > highest)
            {
                highest = ECCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCmats == highest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDmats > highest)
            {
                highest = EMDmats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDmats == highest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPmats > highest)
            {
                highest = ELPmats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPmats == highest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {highest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST REMAINING STOCKS FOR GAMEPRIZES
        public static void HighestRemainingPrizes(int EHWprize, int EHPprize, int ECCprize, int EMDprize, int ELPprize)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR GAME PRIZES IS ");

            int highest = EHWprize;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPprize > highest)
            {
                highest = EHPprize;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPprize == highest)
            {
                messages.Add("HAPPY");
            }

            if (ECCprize > highest)
            {
                highest = ECCprize;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCprize == highest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDprize > highest)
            {
                highest = EMDprize;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDprize == highest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPprize > highest)
            {
                highest = ELPprize;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPprize == highest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {highest} CASES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST REMAINING STOCKS FOR GIVEAWAYS
        public static void HighestRemainingGives(int EHWgive, int EHPgive, int ECCgive, int EMDgive, int ELPgive)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR GIVEAWAYS IS ");

            int highest = EHWgive;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPgive > highest)
            {
                highest = EHPgive;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPgive == highest)
            {
                messages.Add("HAPPY");
            }

            if (ECCgive > highest)
            {
                highest = ECCgive;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCgive == highest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDgive > highest)
            {
                highest = EMDgive;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDgive == highest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPgive > highest)
            {
                highest = ELPgive;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPgive == highest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {highest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // HIGHEST REMAINING STOCKS FOR GIFTS
        public static void HighestRemainingGifts(int EHWgift, int EHPgift, int ECCgift, int EMDgift, int ELPgift)
        {
            Console.Write("THE MOST CONSUMED STOCK FOR GIFTS IS ");

            int highest = EHWgift;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPgift > highest)
            {
                highest = EHPgift;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPgift == highest)
            {
                messages.Add("HAPPY");
            }

            if (ECCgift > highest)
            {
                highest = ECCgift;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCgift == highest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDgift > highest)
            {
                highest = EMDgift;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDgift == highest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPgift > highest)
            {
                highest = ELPgift;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPgift == highest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {highest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LOWEST REMAINING STOCKS FOR PARTY HATS
        public static void LowestRemainingHats(int EHWmats, int EHPmats, int ECCmats, int EMDhats, int ELPhats)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR PARTY HATS IS ");

            int lowest = EHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPmats < lowest)
            {
                lowest = EHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPmats == lowest)
            {
                messages.Add("HAPPY");
            }

            if (ECCmats < lowest)
            {
                lowest = ECCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCmats == lowest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDhats < lowest)
            {
                lowest = EMDhats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDhats == lowest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPhats < lowest)
            {
                lowest = ELPhats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPhats == lowest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {lowest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LOWEST REMAINING STOCKS FOR PARTY TRAYMATS
        public static void LowestRemainingMats(int EHWmats, int EHPmats, int ECCmats, int EMDmats, int ELPmats)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR PARTY TRAYMATS IS ");

            int lowest = EHWmats;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPmats < lowest)
            {
                lowest = EHPmats;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPmats == lowest)
            {
                messages.Add("HAPPY");
            }

            if (ECCmats < lowest)
            {
                lowest = ECCmats;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCmats == lowest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDmats < lowest)
            {
                lowest = EMDmats;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDmats == lowest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPmats < lowest)
            {
                lowest = ELPmats;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPmats == lowest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {lowest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LOWEST REMAINING STOCKS FOR GAME PRIZES
        public static void LowestRemainingPrizes(int EHWprize, int EHPprize, int ECCprize, int EMDprize, int ELPprize)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR GAME PRIZES IS ");

            int lowest = EHWprize;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPprize < lowest)
            {
                lowest = EHPprize;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPprize == lowest)
            {
                messages.Add("HAPPY");
            }

            if (ECCprize < lowest)
            {
                lowest = ECCprize;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCprize == lowest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDprize < lowest)
            {
                lowest = EMDprize;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDprize == lowest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPprize < lowest)
            {
                lowest = ELPprize;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPprize == lowest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {lowest} CASES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LOWEST REMAINING STOCKS FOR GIVEAWAYS
        public static void LowestRemainingGives(int EHWgive, int EHPgive, int ECCgive, int EMDgive, int ELPgive)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR GIVEAWAYS IS ");

            int lowest = EHWgive;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPgive < lowest)
            {
                lowest = EHPgive;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPgive == lowest)
            {
                messages.Add("HAPPY");
            }

            if (ECCgive < lowest)
            {
                lowest = ECCgive;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCgive == lowest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDgive < lowest)
            {
                lowest = EMDgive;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDgive == lowest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPgive < lowest)
            {
                lowest = ELPgive;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPgive == lowest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {lowest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }

        // LOWEST REMAINING STOCKS FOR GIFTS
        public static void LowestRemainingGifts(int EHWgift, int EHPgift, int ECCgift, int EMDgift, int ELPgift)
        {
            Console.Write("THE LEAST CONSUMED STOCK FOR GIFTS IS ");

            int lowest = EHWgift;
            List<string> messages = new List<string> { "HOTWHEELS" };

            if (EHPgift < lowest)
            {
                lowest = EHPgift;
                messages = new List<string> { "HAPPY" };
            }
            else if (EHPgift == lowest)
            {
                messages.Add("HAPPY");
            }

            if (ECCgift < lowest)
            {
                lowest = ECCgift;
                messages = new List<string> { "COCOMELON" };
            }
            else if (ECCgift == lowest)
            {
                messages.Add("COCOMELON");
            }

            if (EMDgift < lowest)
            {
                lowest = EMDgift;
                messages = new List<string> { "MADAGASCAR" };
            }
            else if (EMDgift == lowest)
            {
                messages.Add("MADAGASCAR");
            }

            if (ELPgift < lowest)
            {
                lowest = ELPgift;
                messages = new List<string> { "LITTLE PONY" };
            }
            else if (ELPgift == lowest)
            {
                messages.Add("LITTLE PONY");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(string.Join(" AND ", messages) + $" WITH {lowest} PIECES");
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}

