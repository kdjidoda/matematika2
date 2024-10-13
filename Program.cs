using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematika2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojene razmakom:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int x = Convert.ToInt32(numbers[0]);
            double y = Convert.ToDouble(numbers[1]);

            Console.WriteLine($"Cijeli broj: {x}");
            Console.WriteLine($"Decimale: {y}");
            Console.ReadKey();
        }
    }
}
