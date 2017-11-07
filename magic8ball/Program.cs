using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic8ball
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        private static void PlayGame()
        {
            //array of answers

            string[] answers = { "Maybe", "Nibba You Willin", "Fo Shizzle My Nizzle", "Hell Too The Nah Nah", "Oh Hell No", "Yes", "Not For You Fam", "I Guess You Have A Chance", "ITS EVERYDAY BROOOOOO" };
            Console.Write("Ask Me A Question Fam (or type 'exit'):");
            string choice = Console.ReadLine();
            Random rnd = new Random();
            Console.WriteLine(answers[rnd.Next(0, 9)]);
            Console.ReadKey();
            PlayGame();
        }
        
    }
}
