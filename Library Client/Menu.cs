using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_Client
{
    public class Menu
    {
        //Fields
        public LibraryManager libraryManager;
        public Requests requests;



        //Runs the main menu
        public void MainMenu()
        {
            libraryManager = new LibraryManager();
            requests = new Requests();

            libraryManager.menu = this;
            libraryManager.requests = requests;
            requests.libraryManager = libraryManager;

            bool continuing = true;

            while (continuing == true) 
            {
                Console.Clear();
                Console.WriteLine("Welcome to our library!");
                int menuChoice = GetValidIntegerInput("Choose an option: \r\n" +
                                                      "1. Add a book\r\n" +
                                                      "2. Update a book\r\n" +
                                                      "3. See all books\r\n" +
                                                      "4. Remove a book\r\n" +
                                                      "5. Exit\r\n");

                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add a book\n");
                        libraryManager.AddNewBook();
                        BackToMainMenu();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Update a book");
                        libraryManager.UpdateBook();
                        BackToMainMenu();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("See all books");
                        libraryManager.DisplayAllBooks();
                        BackToMainMenu();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Remove a book");
                        // Lägg till kod för att ta bort en bok
                        BackToMainMenu();
                        break;

                    case 5:
                        continuing = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        BackToMainMenu();
                        break;
                }
            }
           
        }

        void BackToMainMenu()
        {
            Console.WriteLine("Press Enter to return to the main menu");
            Console.ReadLine();
        }


        int GetValidIntegerInput(string message)
        {
            int userInput;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

    }
}
