using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTask
{
    internal class LoopingMenu
    {
        public static void ShowLoopingMenu()
        {
            Console.WriteLine(
                "The Looping Menu\n" +
                "----------------\n");

            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.{text}, ");
            }
            Console.WriteLine();
        }
    }
}
