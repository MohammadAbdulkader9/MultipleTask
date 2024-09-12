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
                "1. Bio System\n" +
                "2. Looping System\n" +
                "3. Wording System\n" +
                "------------------------------");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {                    
                    case 1:
                        BioMenu();
                        break;

                    case 2:
                        LoopingMenu();
                        break;

                    case 3:
                        WordMenu();
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

        public static void BioMenu()
        {
            bool programStatus = true;
            int visitorChoice;

            Console.WriteLine(
                "Bio Menu\n" +
                "---------\n" +
                "* Teenager price: 80 Kr\n" +
                "* Pensions price: 90 Kr\n" +
                "* Standard price: 120 Kr\n" +
                "-For single visit enter 1\n" +
                "-For multiple visitor enter 2");

            do
            {
                //programStatus = true;
                int.TryParse(Console.ReadLine(), out visitorChoice);

                switch (visitorChoice)
                {
                    case 1:
                        SingleVisitor();
                        break;

                    case 2:
                        MultipleVisitor();
                        break;

                    default:
                        Console.WriteLine("Wrong input!");
                        break;

                }
                programStatus = false;
            }
            while (programStatus != false);
                      
            //Single visitor controll
            static void SingleVisitor()
            {
                int teenageerPrice = 80;
                int pensionPrice = 90;
                int standardPrice = 120;

                int age;
                Console.Write("Enter Age: ");
                age = int.Parse(Console.ReadLine());
                if (age > 5 && age < 20)
                    Console.WriteLine($"Price is {teenageerPrice} kr");
                else if (age > 64 && age < 100)
                    Console.WriteLine($"Price is {pensionPrice} kr");
                else if (age >= 100)
                    Console.WriteLine("Congrats free entry for you");
                else if (age <= 5)
                    Console.WriteLine("Too young to enter alone!");
                else
                    Console.WriteLine($"Price is {standardPrice} kr");
            }

            //multiple visitors controll
            static void MultipleVisitor()
            {
                int age;
                int visitors;
                int total = 0;

                int teenageerPrice = 80;
                int pensionPrice = 90;
                int standardPrice = 120;
               
                Console.Write("Enter visitors amount: ");
                visitors = int.Parse(Console.ReadLine());                                            

                for (int i = 0; i < visitors; i++) {
                    Console.Write($"Enter age for person {i+1}: ");
                    age = int.Parse(Console.ReadLine());

                    if ( age > 5 && age < 20)
                        total += teenageerPrice;
                    else if (age > 64 && age < 100)
                        total += pensionPrice;
                    else if (age >= 20 && age <= 64)
                        total += standardPrice;
                    else if (age <= 5 || age >= 100)
                        total += 0;
                }
                Console.WriteLine("Total to pay:" + total);
            }
        }
        public static void LoopingMenu()
        {
            Console.WriteLine("Repeat Menu");
            Console.WriteLine("-----------");
        }
        public static void WordMenu()
        {
            Console.WriteLine("Word Menu");
            Console.WriteLine("---------");
        }

    }
}
