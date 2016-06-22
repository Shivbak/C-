using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            string input = "X" ;
            List<string> books = new List<string>();
            books.Add("book1");
            books.Add("book2");
            books.Add("book3");
            books.Add("book4");

            for(var i =0; i < books.Count; i++ )
            {
                Console.WriteLine(books[i]);
            }

            Console.WriteLine("A : Add New Book");
            Console.WriteLine("D : Delete a Book");
            Console.WriteLine("L : List the Books");
            Console.WriteLine("S : Sort the Books");
            Console.WriteLine("X : Exit");




            do
            {
                Console.WriteLine("Enter Any one Charactor for operation : ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("Enter value : ");
                        value = Console.ReadLine();
                        books.Add(value);
                        Console.WriteLine("Your List is : ");
                        for (var i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i]);
                        }

                        break;

                    case "D":
                    case "d":
                        Console.WriteLine("Enter value : ");
                        value = Console.ReadLine();
                        books.Remove(value);
                        Console.WriteLine("Your List is : ");
                        for (var i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i]);
                        }

                        break;

                    case "L":
                    case "l":
                        Console.WriteLine("Your List is : ");
                        for (var i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i]);
                        }

                        break;

                    case "S":
                    case "s":
                        books.Sort();
                        Console.WriteLine("Your List is : ");
                        for (var i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i]);
                        }

                        break;
                    case "X":
                    case "x":
                        return;

                    default:
                        Console.WriteLine("sorry....Wrong charactor");
                        break;


                }
            } while ((input != "X") || (input != "x"));
        }
    }
}
