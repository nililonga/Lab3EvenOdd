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
            //declare an integer
            int answer;

            //have user enter a number
            Console.WriteLine("Enter a number between 1 and 100:");
            answer = int.Parse(Console.ReadLine());

            //determine even numbers between the range of 2 to 25
            if  (answer <= 25 && answer > 2 & answer % 2 == 0)
            {
                Console.WriteLine(answer + " is an even number and less than 25");
            
            //determine even numbers between the range of 26 to 60
            } else if (answer >= 26 && answer <= 60 & answer % 2 == 0) 
            
            {
                Console.WriteLine(" Even");
            }
            //determine even numbers greater than 60
            else if (answer > 60 & answer % 2 == 0)
            {
                Console.WriteLine(answer + " is Even");
            }
            //determine odd numbers greater than 60
            else if (answer % 2 == 0 & answer > 60)
            {
                Console.WriteLine(answer + " is odd");
            }

            else
            {
                Console.WriteLine(answer + " is Odd");
            }

            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey(true);




        }
    }
}
