using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassessment_1
{
    public class Books
    {
        public string Title;
        public string Author;
        public int ISBN;
        public int Price;

        public void AddBook(string title, string author, int ISBN, int price )
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
            this.Price = price;
        }

        public static void List_of_Books(List<Books> listofbooks)
        {
            foreach(Books name in listofbooks)
            {
                Console.WriteLine("Book Title: {0} Author : {1} ISBN : {2} Price {3} ",name.Title,name.Author, name.ISBN , name.Price);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Delete_book;
            string User_input;
            List<Books> ListOfBooks = new List<Books>();
            Books book1 = new Books();
            Books book2 = new Books();
            Books book9 = new Books();
            book1.AddBook("The Grapes Of Wrath", "By John Steinbeck", 001, 100);
            book9.AddBook("abc", "By John Steinbeck", 001, 100);

            ListOfBooks.Add(book1);
            ListOfBooks.Add(book9);
            Books.List_of_Books(ListOfBooks);

            Console.WriteLine("Enter A to Add New Book in List");
            Console.WriteLine("Enter L to view List of Books");
            Console.WriteLine("Enter D to Delete any book from List");
            Console.WriteLine("Enter X to Exit");
            

            do
            {
                Console.WriteLine("Enter any char : ");
                User_input = (Console.ReadLine()).ToUpper();
                switch (User_input)
                {
                    case "A":
                        Console.WriteLine("Enter New Book Name:");
                        book2.Title = Console.ReadLine();
                        Console.WriteLine("Enetr Author Name :");
                        book2.Author = Console.ReadLine();
                        Console.WriteLine("Enter International Standard Book Number :");
                        book2.ISBN = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Price of Book :");
                        book2.Price = Convert.ToInt32(Console.ReadLine());
                        ListOfBooks.Add(book2);
                        Books.List_of_Books(ListOfBooks);
                        break;

                    case "L":
                       
                        Books.List_of_Books(ListOfBooks);
                        break;

                    case "D":
                        Console.WriteLine("Enter Name of Book that You want to Delete :");
                        Delete_book = Console.ReadLine();
                        Console.WriteLine("book to delete is:" + Delete_book);
                        foreach (Books iteam in ListOfBooks)
                        {
                           
                                ListOfBooks.Remove(book1);

                            
                        }
                        
                        Books.List_of_Books(ListOfBooks);
                        break;

                    case "X":
                        return;


                    default:
                        break;
                }
            } while (User_input != "X");
        }
    }
}
