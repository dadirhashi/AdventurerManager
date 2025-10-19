using AdventurerManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventurerManager.Services
{
    public class QuestManager
    {
        
        private List<Quest> quests;

        public QuestManager (List<Quest> userquests)
        {
            quests = userquests;
        }

        public void AddQuest()
        {
            Console.WriteLine("Enter a Quest titel: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Quest description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter due date (yyyy-mm-dd):");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("nter priority (Low, Medium, High):");
            PriorityLevel priority = Enum.Parse<PriorityLevel>(Console.ReadLine(), true);

            quests.Add(new Quest
            {
                Titel = title,
                Descripton = description,
                DuaDate = dueDate,
                priority = priority,
                IsCompleted = false
            }
                );

            Console.WriteLine(" Quest added succesfully");

        }
        public void ShowAllQuest()
        {
            if (quests.Count == 0)
            {
                Console.WriteLine("No quest available... ");

            }
            else 
            {
                Console.WriteLine("You have available quest");
            }

            foreach (Quest quest in quests)
            {
                Console.WriteLine($"{quest.Titel} - {quest.priority} - Due: {quest.DuaDate.ToShortDateString()}");

            }
        }

        public void CompleteQuest()
        {
            Console.WriteLine("Enter quest titel to complet");
            string titel = Console.ReadLine();

            // Öppnar får quest lista returnerar första matchande objektet eller null om inget hittas,
            // Det gör också jämförelser mellan olika quest titlar med de användaren mattar in.
            var quest = quests.FirstOrDefault(q => q.Titel.Equals(titel, StringComparison.OrdinalIgnoreCase));

            if (quest != null)
            {
                quest.IsCompleted = true;
                Console.WriteLine("Quest mark as Completed! ");
            }
            else
            {
                Console.WriteLine("Quest not found! ");
            
            }

        }


    }
}
