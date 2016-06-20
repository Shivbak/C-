using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int avg;
            int total = 0;
            for(var i =0 ; i< num.Length; i++)
            {
                Console.WriteLine("Enter number : " );
                num[i] = Convert.ToInt32(Console.ReadLine());
                total += num[i];
            }

            
            avg = total / num.Length;
            Console.WriteLine("Average is : " + avg);
            Console.ReadKey();
        }
    }
}
