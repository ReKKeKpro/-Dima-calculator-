using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());
            double result = (a + b) / 2;
            Console.WriteLine("Результат: " + result );
        }
    }
}
