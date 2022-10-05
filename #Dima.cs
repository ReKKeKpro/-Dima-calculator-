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
            string bd;
            int a, b, c;
            Console.WriteLine("Введите 1 число");
            bd = Console.ReadLine();
            a = Convert.ToInt32(bd);
            Console.WriteLine("Введите 2 число");
            bd = Console.ReadLine();
            b = Convert.ToInt32(bd);
            Console.WriteLine("Введите 3 число");
            bd = Console.ReadLine();
            c = Convert.ToInt32(bd);
            int result = a * b - c;
            Console.WriteLine("Сумма чисел = " + result);
           
            

        }
    }
}
