using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_problem_code_eval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");

            //int numberEntered = 20;
            int numberEntered = int.Parse(Console.ReadLine());
           // int numberEntered = int.Parse(line); // need this for code eval

            int numberTested = (numberEntered % 2);
            if (numberTested == 0)
            {
                Console.WriteLine("1"); // will print if number is even
            }
            else
            {
                Console.WriteLine("0"); //will print if number is odd
            }
        }
    }
}
