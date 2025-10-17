using AdventurerManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventurerManager.Services
{
    public class Authenticator
    {
        private List<User> users = new List<User>();

        // Registrera en ny hjälte
        public void RegisterHero() 
        {
            Console.WriteLine("Enter hero name: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter Your email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your phone nummber");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());


            // Rnkel lösnordsvalidering, jag bygga säkerheten lite senare om jag har tiden för det men för tillvället får dett enka validering räka.
            if (password.Length <6)
            {
                Console.WriteLine("Password must at least be 6 characters or more");
                return;
            }

            User user = new User
            {
                UserName = username,
                Password = password,
                Email = email,
                PhoneNumber = phoneNumber
            };
            
            users.Add(user);
            Console.WriteLine($"Hero {username} registered successfully");

        }

        // Inlogning för hjälten.
        public User LoginHero()
        {
            Console.Write("Enter hero name: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var user = users.FirstOrDefault(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);

            if (user != null)
            {
                Console.WriteLine($"Welcome back hero, {user.UserName}!!");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                return null;
            
            }

        }
    }
}
