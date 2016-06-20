using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1 , answer2;

            int attempt = 3;

            Console.WriteLine("Ready...!!");
            
            string play = "Y";

           
            
                do {
                    
                    if (attempt > 0)
                    {
                        Console.WriteLine("What has a face and two hands but no arms or legs");

                        answer1 = Console.ReadLine().ToUpper();

                        if ((answer1 == "A CLOCK") || (answer1 == "CLOCK"))
                        {
                            Console.WriteLine("Answer is Correct");
                        Console.WriteLine("Enter Y for Continue and N for exit");
                        play = Console.ReadLine();
                        break;

                        }

                        else
                        {
                            attempt--;
                           
                            while (attempt >0 )
                            {
                                Console.WriteLine("Your answer is wrong and only " + attempt + " attampt left.");
                                Console.WriteLine("Press Y for continue and N for pass");
                                play = Console.ReadLine();
                                
                                break;
                            }

                            if(attempt == 0)
                            {
                                Console.WriteLine("sorry..!!");
                            Console.WriteLine("Enter Y for Continue and N for exit");
                            play = Console.ReadLine();
                            break;
                            }
                        }
                    }
                   
                } while (play != "N");

            attempt = 3;

            while (play == "Y")
            {
                if (attempt > 0)
                {
                    Console.WriteLine("Everyone has it and no one can lose it, what is it?");

                    answer2 = Console.ReadLine().ToUpper();

                    if ((answer2 == "A SHADOW") || (answer2 == "SHADOW"))
                    {
                        Console.WriteLine("Answer is Correct");
                        play = "N";
                        break;

                    }
                    else
                    {
                        attempt--;
                        while (attempt > 0)
                        {
                            Console.WriteLine("Your answer is wrong and only " + attempt + " attampt left.");
                            Console.WriteLine("Press Y for continue and N for pass");
                            play = Console.ReadLine();
                            break;
                        }

                        if(attempt == 0)
                        {
                            Console.WriteLine("sorry..!!");
                            break;
                        }
                    }

                }
            }

                Console.WriteLine("Game over");
            
            
        }
    }
}
