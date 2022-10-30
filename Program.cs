using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть значення а");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення c");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення d");
            double d = double.Parse(Console.ReadLine());

            if (Math.Abs(Math.Pow(b, 2) - Math.Pow(a, 2)) * Math.Sin(c) != 0)
                Console.WriteLine("Відповідь - " +  Math.Log(d, 2.7183) / (Math.Abs(Math.Pow(b, 2) - Math.Pow(a, 2)) * Math.Sin(c)));
            else
                Console.WriteLine("Неможливо знайти значення функції, оскільки знаменник дробу = 0");
            Console.ReadLine();
        }
    }
}
