using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var wishlist = new string[3];

            Console.WriteLine("Skriv in 3 saker du önskar dig");

            for (int i = 0; i < wishlist.Length; i++)
            {
                wishlist[i] = Console.ReadLine();
            }

            Array.Sort(wishlist);
            //    for (int i = 0; i < wishlist.Length; i++)
            //   {
            //     Console.WriteLine(wishlist[i]);
            //   }

            foreach (var item in wishlist)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}

