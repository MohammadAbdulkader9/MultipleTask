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
                Console.WriteLine("------------------------------");
                Console.WriteLine("0. Exit Menu");
                Console.WriteLine("1. Bio System");
                Console.WriteLine("2. Looping System");
                Console.WriteLine("3. Wording System");
                Console.WriteLine("------------------------------");
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
            Console.WriteLine(
                $"Bio Menu\n" +
                "---------\n" +
                "* Teenager price: 80 Kr\n" +
                "* Pensions price: 90 Kr\n" +
                "* Standard price: 120 Kr\n" +
                "For single visit enter 1\n" +
                "For multiple visitor enter 2");
            
            int visitorChoice = 1;
            int teenageerPrice = 80;
            int pensionPrice = 90;
            int standardPrice = 120;
            

            int result;
            int.TryParse(Console.ReadLine(), out visitorChoice);

            switch (visitorChoice) {
                case 1:
                    SingleVisitor();
                    break;

                case 2:
                    MultipleVisitor();
                    break;

            }
            
            static void SingleVisitor()
            {
                int age;
                Console.Write("Enter Age: ");
                age = int.Parse(Console.ReadLine());
                if (age < 20)
                    Console.WriteLine("price is 80 kr");
                else if (age > 64)
                    Console.WriteLine("price is 90 kr");
                else
                    Console.WriteLine("Price is 120 kr");
            }

            static void MultipleVisitor()
            {
                int age;
                int visitors;
                int total = 0;

                Console.Write("Enter visitors amount: ");
                visitors = int.Parse(Console.ReadLine());                                            

                for (int i = 0; i < visitors; i++) {
                    Console.Write($"Enter age for person {i+1}: ");
                    age = int.Parse(Console.ReadLine());

                    if (age < 20)
                        total += 80;
                    else if (age > 64)
                        total += 90;
                    else if (age >= 20 && age <= 64)
                        total += 120;
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
