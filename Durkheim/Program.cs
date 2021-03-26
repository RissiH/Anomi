using System;

namespace Durkheim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marxism or Functionalism, please write in lower case.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "functionalism")
                {
                    Console.WriteLine("What are you? Gay?");

                }
                else if (input.ToLower() == "marxism")
                {
                    Console.WriteLine("Nice, me too!");
                }
                else if (input.ToLower() == "communism") //I need to pee
                {
                    Console.WriteLine("Good Evening, Comrade"); //this also does a thing
                }
                else
                {
                    Console.WriteLine("Answer the question potential capitalist."); //This does a thing
                }
            }
        }
            
    }
}
