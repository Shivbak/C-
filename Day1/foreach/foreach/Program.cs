using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful" };

            for(var i =0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine("Your Dinner is Ready : " + sevenDwarves [i]);
            }

            foreach (string i in sevenDwarves)
            {
                Console.WriteLine("Your Drink is Ready : " + i);
            }
        }
    }
}
