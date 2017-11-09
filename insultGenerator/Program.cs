using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for your name
           

            //Generate a random insult
            GenerateSong();
        }

        private static void GenerateSong()
        {
            string[] WordsOne = { "Two plus two is four, minus one that's three", "quick maths", "smoke trees",
                "Everyday man's on the block", "See your girl in the park", "that girl is a uckers",
                "When the ting went quack-quack-quack, you man were ducking","Hold tight, Asnee","he's got the pumpy","Hold tight","my man, he's got the frisbee",
                "I trap","trap","trap on the road","movin' that cornflakes","hah","look at your nose","What? You dickhead! Look at your nose","Nose long like garden hose, shhh, you get me?" };

            string[] WordsTwo = {"Hop out the four-door with the .44, it was one, two, three and four","Chillin' in the corridor, your dad is forty-four","And he's still callin' man for a draw, let him know",
                "And he's still callin' man for a draw, let him know","When I see him, I'm gonna spin his jaw",};

            string[] Noises = {"quack-quack-quack", "The ting goes skrrrahh, pap, pap, ka-ka-ka" ,"Skya du-du-ku-ku-dun-dun", "Poom, poom"};

            Random rnd = new Random();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(WordsOne[rnd.Next(0, 19)] + ", " + WordsTwo[rnd.Next(0, 5)] + ", " + Noises[rnd.Next(0, 4)]);
            }
            


            Console.ReadKey();



        }
    }
}
