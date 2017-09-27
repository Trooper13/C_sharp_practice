using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = 1.23;
            Console.WriteLine(tmp);
            Console.ReadKey();

            int[] tab = new int[6] { 1,2,3,4,5,6};
            for (int i =0; i<tab.Length; i++)
            {
                Console.Write(tab[i]+", ");
            }
            Console.ReadKey();
        }
    }
}
