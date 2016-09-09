using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_PigLatinTranslator
{
    class Program
    {
        static string play;
        static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                do
                {
                    Console.WriteLine("\nEnter a line to be translated:");
                    string lineTranslate = Console.ReadLine();

                    translator line = new translator();
                    string newSentence = line.Translate(lineTranslate.ToLower());

                    Console.WriteLine(newSentence);

                    continueOrQuit();

                } while (play.ToLower() == "y" || play.ToLower() == "yes");
            }

        private static void continueOrQuit()
        {
            Console.WriteLine("\nTranslate another line? (y/n)");
            play = Console.ReadLine();
        }
    }
}

