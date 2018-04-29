using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_CAPSTONE_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {

            bool usertranslate = true;


            Console.WriteLine();
            Console.Write(" Welcome to the Pig Latin Translator!");


            while (usertranslate == true)
            {

                Console.WriteLine();
                Console.WriteLine(" Enter a word please to be translated:");
                string word2 = Console.ReadLine();//

                char[] vowel = { 'a', 'e', 'i', 'o', 'u' };


                //string word2 = word.ToLower();//converting upper to lower

                int index = word2.ToLower().IndexOfAny(vowel);
                Console.WriteLine(index);

                if (index == 0)//means the first letter is a vowel thats why its index == 0

                {
                    Console.WriteLine(word2 + "way");//printing out the output of the word and adding 'way' if it starts with a vowel

                }
                else
                {
                    string Ending = word2.Substring(index);//substring splits the word
                    string Beginning = word2.Substring(0, index);

                    Console.WriteLine($"{Ending}{Beginning}{"ay"}");//printing out the output of the word and adding 'ay' at the end if it doesnt start with a vowel

                }

                Console.WriteLine();//creates space in between the sentences

                Console.WriteLine("Do you want to translate another line? (y/n) :");
                string input = Console.ReadLine();

                if (input.ToLower() == "y")

                {
                    usertranslate = true;
                }

                else
                {
                    usertranslate = false;
                    Console.WriteLine("Have a good day!");
                }

            }
        }
    }
}





