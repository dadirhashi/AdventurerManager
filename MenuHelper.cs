using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventurerManager
{
    public static class MenuHelper
    {
        
            public static void ShowMainMenu()
            {
                Console.Clear();
                Console.WriteLine(" Welcome to the Quest Guild Terminal ");
                Console.WriteLine("1. Register hero");
                Console.WriteLine("2. Login hero");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
            }

            public static void ShowHeroMenu(string heroName)
            {
                Console.Clear();
                Console.WriteLine($" Welcome, {heroName}! What would you like to do?");
                Console.WriteLine("1. Add new quest");
                Console.WriteLine("2. View all quests");
                Console.WriteLine("3. Update/Complete quest");
                Console.WriteLine("4. Request Guild Advisor help (AI)");
                Console.WriteLine("5. Show guild report");
                Console.WriteLine("6. Logout");
                Console.Write("Choose an option: ");
            }

            public static void ShowInvalidOption()
            {
                Console.WriteLine("❌ Invalid option. Please try again.");
            }

            public static void Pause()
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        
    }


}

