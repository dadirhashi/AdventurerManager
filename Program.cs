using AdventurerManager.Models;
using AdventurerManager.Services;

namespace AdventurerManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                UserName = "Dadir",
                Password = "dadir123",
                
            };

            Authenticator authenticator = new Authenticator();
           



            QuestManager questManager = new QuestManager(user.Quests);
            
            bool running = true;

            while (running)
            {
                MenuHelper.ShowMainMenu();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Register hero..");
                        authenticator.RegisterHero();
                        questManager.AddQuest();
                        MenuHelper.Pause();
                        break;
                    case "2":
                        Console.WriteLine("Login hero..");
                        authenticator.LoginHero();
                        MenuHelper.Pause();
                        break;
                    case "3":
                        Console.WriteLine("Exiting Guild Terminal. Farewell Hero!");
                        running = false;
                        break;

                        default:
                        MenuHelper.ShowInvalidOption();
                        MenuHelper.Pause();
                        break;

                
                }
            
            
            }
        }
    }
}
