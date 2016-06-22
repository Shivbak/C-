using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, string> language = new Dictionary<string, string>();

            language.Add("C#", "It is similar to Java");
            language.Add("ASP.Net", "It is Based on C#");
            language.Add("JavaScript", "It is for frontend developers. ");

            Console.WriteLine("Enetr L for List");
            Console.WriteLine("Enter K for Key");
            Console.WriteLine("Enter D for description");
            Console.WriteLine("Enter C for Count the list");
            Console.WriteLine("Enter A for Add");
            Console.WriteLine("Enetr E for Edit");
            Console.WriteLine("Enetr R for Remove");
            Console.WriteLine("Enter X for Exit");

            do
            {
                Console.WriteLine("Enter Charactor for operation : ");
                input = (Console.ReadLine()).ToUpper();
                

                switch(input)
                {
                    case "L":
                        Console.WriteLine("Your List is as below: ");
                        foreach (KeyValuePair<string, string> lang in language)
                        {
                            Console.WriteLine(lang.Key.ToString() + " - " + lang.Value.ToString());
                        }
                        break;

                    case "K":
                        Console.WriteLine("Keys are:");
                        foreach(KeyValuePair<string,string> lang in language)
                        {
                            Console.WriteLine(lang.Key.ToString());
                        }
                        break;

                    case "D":
                        Console.WriteLine("Descriptions are : ");
                        foreach (KeyValuePair<string, string> lang in language)
                        {
                            Console.WriteLine(lang.Value.ToString());
                        }
                        break;

                    case "C":
                        Console.WriteLine("Number of Items in dictinary : ");
                        Console.WriteLine(language.Count);
                        break;

                    case "A":
                        Console.WriteLine("Enter Key : ");
                        String key = Console.ReadLine();
                        Console.WriteLine("Enter Value : ");
                        String value = Console.ReadLine();
                        language.Add(key, value);
                        break;

                    case "E":
                                Console.WriteLine("Enter key that you want to edit");
                                string ekey = Console.ReadLine();
                                language.Remove(ekey);
                                Console.WriteLine("Enter new key:");
                                string nkey = Console.ReadLine();

                                Console.WriteLine("Enter description :");
                                string nvalue = Console.ReadLine();
                                language.Add(nkey,nvalue);
                                break;
                       

                    case "R":
                        Console.WriteLine("Enetr key that you want to Remove :");
                        string remove = Console.ReadLine();
                        language.Remove(remove);
                        break;

                    case "X":
                        return;

                    default:

                        Console.WriteLine("Sorry.. Wrong charactor.");
                        break;
                }


            } while (input != "X");


        }
    }
}
