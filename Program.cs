using System;

namespace MultipleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multiple Tasks Menu");
            
            bool programStatus = true;
            int choice;
            do
            {
                Console.WriteLine(
                "------------------------------\n"+
                "0. Exit Menu\n" +
                "1. Bio Menu\n" +
                "2. Looping Menu\n" +
                "3. Wording Menu\n" +
                "------------------------------");

                int.TryParse(Console.ReadLine(), out choice);

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
            while (programStatus != false);          
        }    
    }
}
