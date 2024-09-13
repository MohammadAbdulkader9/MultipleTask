using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTask
{
    internal class WordMenu
    {
        public static void ShowWordMenu()
        {
            Console.WriteLine(
                "The Third Word Menu\n" +
                "-------------------");
            Console.WriteLine(
                "This program collect and display the third word in the text\n"+
                "-----------------------------------------------------------");
            Console.WriteLine("Write a text that contains at least 3 words: ");          

            bool programStatus = true;

            do {
                string text = Console.ReadLine();
                string[] words = text.Split(' ');

                //validating the requirement
                if (words.Length < 3)
                {
                    Console.WriteLine("Text is less than 3 words, try again!");
                }
                else
                {
                    //choosing the 3rd word
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (i == 2)
                            Console.WriteLine($"The third word is: {words[i]}");
                    }
                    programStatus = false;
                }
            } while (programStatus);

            
            
        }
    }
}
