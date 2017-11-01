using System;
using System.Collections.Generic;
using System.Linq;
namespace LambdaExpression
{
    class Program
    {
        static void Lambda()
        {
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Tworzymy listę liczb nieparzystych
            // W pierwszej kolejności używamy metody rozszerzającej dla naszej kolekcji (.Where)
            // A następnie wyrażenia lambda do sprawdzenia, które liczby są niepatrzyste
            List<int> oddNumber = number.Where(n => n % 2 == 1).ToList();
            // Wypisujemy liczby niepatrzyste 
            Console.WriteLine("Liczby niepatrzyste: ");
            foreach (var item in oddNumber)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            // Wynik działania programu
            // Liczby niepatrzyste:
            // 1
            // 3
            // 5
            // 7
            // 9
        }
    }
}