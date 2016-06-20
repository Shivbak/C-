using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Start...");


            int input;

            

            string play = "Y";

            while(play == "Y")
            {

                

                Random random = new Random();
                int rnd = random.Next(1, 10);
                do
                {
                    Console.WriteLine("Enter Number : ");
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < rnd)
                    {
                        Console.WriteLine("Your number is less than the Number I Guess ");
                    }
                    else if (input > rnd)
                    {
                        Console.WriteLine("Your number is Greater than the Number I Guess ");
                    }
                    else
                    {
                        Console.WriteLine("Correct Guess");

                    }

                } while (input != rnd);

                Console.WriteLine("Enter Y to continue and N to Stop");
                play = Console.ReadLine();

            } 

        }
    }
}
