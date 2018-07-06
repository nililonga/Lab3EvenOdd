using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a variable
            int answer;
            string answerN;

            //have user enter name
            Console.WriteLine("Hello, please enter your name:");
            answerN = Console.ReadLine();

            //have user enter number 
            Console.WriteLine($"Thanks {answerN}! Now enter a number between 1 and 100:");
            answer = int.Parse(Console.ReadLine());

            //validate that number is between 1 and 100
            while (answer < 1 || answer > 100)
            {
                Console.WriteLine("That was not a valid number, please try again.");
                answer = int.Parse(Console.ReadLine());
            }
                //determine even numbers between the range of 2 to 25
                if (answer <= 25 && answer > 2 && answer % 2 == 0)
                {
                    Console.WriteLine($"Okay {answerN}, {answer} +  is an even number and less than 25");

                    //determine even numbers between the range of 26 to 60
                }
                else if (answer >= 26 && answer <= 60 && answer % 2 == 0)

                {
                    Console.WriteLine(" Even");
                }
                //determine even numbers greater than 60
                else if (answer > 60 & answer % 2 == 0)
                {
                    Console.WriteLine($"Okay {answerN}, {answer} + is Even");
                }
                //determine odd numbers greater than 60
                else if (answer % 2 == 0 & answer > 60)
                {
                    Console.WriteLine($"Okay {answerN}, {answer} +  is odd");
                }

                else
                {
                    Console.WriteLine($"Okay {answerN}, {answer} + is Odd");
                }

                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey(true);



            
        }
    }
}
