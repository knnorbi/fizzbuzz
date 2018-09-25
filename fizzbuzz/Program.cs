using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Meddig számoljak? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FIZZBUZZ");
                else if(i % 3 == 0)
                    Console.WriteLine("FIZZ");
                else if(i % 5 == 0)
                    Console.WriteLine("BUZZ");
                else
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
