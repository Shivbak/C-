using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second  number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter A for addition");
            Console.WriteLine( "Enter D for divition" );
            string input = Console.ReadLine();

            switch (input)
            {
                case "A":
                case "a":   

                    Console.WriteLine("Addition is : " + (number1 + number2));
                    break;

                case "D":
                case "d":

                    Console.WriteLine("Divition is : " + (number1 / number2));
                    break;

                default :

                    Console.WriteLine("Enter A or D ");
                    break;


            }
        }
    }
}
