using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Client
{
    public class Menu
    {
        public void MainMenu()
        {
            bool continuing = true;

            while (continuing == true) 
            {
                Console.Clear();
                Console.WriteLine("Welcome to our library!");
                Console.WriteLine("Choose an option: \n");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Update a book");
                Console.WriteLine("3. See all books");
                Console.WriteLine("4. Remove a book");
                Console.WriteLine("5. Exit\n");

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add a book\n");
                        
                       

                       
                        Console.WriteLine("Press Enter to return to the main menu");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Update a book");
                        // Lägg till kod för att uppdatera en bok
                        Console.WriteLine("Press Enter to return to the main menu");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("See all books");
                        // Lägg till kod för att visa alla böcker eller om vi bara vill visa några specifika
                        Console.WriteLine("Press Enter to return to the main menu");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Remove a book");
                        // Lägg till kod för att ta bort en bok
                        Console.WriteLine("Press Enter to return to the main menu");
                        Console.ReadLine();
                        break;

                    case 5:
                        continuing = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("Press Enter to return to the main menu");
                        Console.ReadLine();
                        break;
                }
            }
           
        }

    }
}
