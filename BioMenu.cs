using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTask
{
    internal class BioMenu
    {
        public static void ShowBioMenu()
        {
            bool programStatus = true;
            int visitorChoice;

            Console.WriteLine(
                "The Bio Menu\n" +
                "------------\n");

            Console.WriteLine(
                "* Teenager price: 80 Kr\n" +
                "* Pensions price: 90 Kr\n" +
                "* Standard price: 120 Kr\n" +
                "-For single visit enter 1\n" +
                "-For multiple visitor enter 2");

            do
            {
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
                programStatus = false; // to go back to main menu
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

                for (int i = 1; i <= visitors; i++)
                {
                    Console.Write($"Enter age for person {i}: ");
                    age = int.Parse(Console.ReadLine());

                    if (age > 5 && age < 20)
                        total += teenageerPrice;
                    else if (age > 64 && age < 100)
                        total += pensionPrice;
                    else if (age >= 20 && age <= 64)
                        total += standardPrice;
                    else if (age <= 5 || age >= 100)
                        total += 0;
                }
                Console.WriteLine($"* Total to pay {total} for {visitors} visitors");
            }
        }
    }
}
