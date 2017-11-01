using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_sharp_practice
{
    class Program
    {
        static void Lambda(string name)
        {
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Tworzymy listę liczb nieparzystych
            // W pierwszej kolejności używamy metody rozszerzającej dla naszej kolekcji (.Where)
            // A następnie wyrażenia lambda do sprawdzenia, które liczby są niepatrzyste

            if (name == "parzyste")
            {
                List<int> oddNumber = number.Where(n => n % 2 == 0).ToList();
                // Wypisujemy liczby niepatrzyste 
                Console.WriteLine("Liczby patrzyste: ");
                foreach (var item in oddNumber)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
            else
            if (name == "nieparzyste")
            {
                List<int> oddNumber = number.Where(n => n % 2 == 1).ToList();
                // Wypisujemy liczby niepatrzyste 
                Console.WriteLine("Liczby niepatrzyste: ");
                foreach (var item in oddNumber)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
            else Console.WriteLine("Błędny parametr");
            // Wynik działania programu
            // Liczby niepatrzyste:
            // 1
            // 3
            // 5
            // 7
            // 9
        }
        static void writeList()
        {
            var tmp = 1.23;
            Console.WriteLine(tmp);
            Console.ReadKey();

            int[] tab = new int[6] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + ", ");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
         
            Lambda("parzyste");
            Lambda("nieparzyste");
            Lambda("dupa");
            Console.ReadKey();
        }
    }
}
