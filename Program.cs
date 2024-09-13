using System;

namespace MultipleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Welcome to Multiple Tasks Menu\n"+
                "Enter number to navigate");

            bool programStatus = true;

            do
            {
                Console.WriteLine(
                "------------------------------\n"+
                "1. Bio Menu\n" +
                "2. Loop Menu\n" +
                "3. Word Menu\n" +
                "0. Exit Menu\n" +
                "------------------------------");

                int choice;
                               
                if (int.TryParse(Console.ReadLine(), out choice)) //check if the choice i correct
                {
                    switch (choice)
                    {
                        case 1:
                            BioMenu.ShowBioMenu();
                            break;

                        case 2:
                            LoopingMenu.ShowLoopingMenu();
                            break;

                        case 3:
                            WordMenu.ShowWordMenu();
                            break;

                        case 0:
                            Console.WriteLine("Exit");
                            programStatus = false;
                            break;

                        default:
                            Console.WriteLine("Wrong input!");
                            break;
                    }
                }
                else // if a non-numeric choice is entered
                {
                    Console.WriteLine("Wrong input!");
                }                
            }
            while (programStatus != false);          
        }    
    }
}
