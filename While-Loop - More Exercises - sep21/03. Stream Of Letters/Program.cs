using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            string currentWord = "";
            int comandCounter = 0;
            int cCounter = 0;
            int oCounter = 0;
            int nCounter = 0;

            while (input != "End")
            {
                char letter = char.Parse(input);
                bool isLetter = char.IsLetter(letter);

                if (isLetter == true)
                {
                    

                    if (letter == 'c' && cCounter == 0)
                    {
                        cCounter++;
                        comandCounter++;
                    }
                    else if (letter == 'o' && oCounter == 0)
                    {
                        oCounter++;
                        comandCounter++;
                    }
                    else if (letter == 'n' && nCounter == 0)
                    {
                        nCounter++;
                        comandCounter++;
                    }
                    else
                    {
                        currentWord += char.ToString(letter);
                    }

                    if (comandCounter == 3)
                    {
                        comandCounter = 0;
                        cCounter = 0;
                        oCounter = 0;
                        nCounter = 0;

                        currentWord += " ";
                        output += currentWord;
                        currentWord = "";
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine(output);
        }
    }
}
