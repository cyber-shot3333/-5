using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Console.WriteLine("Введите число 0");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 1");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            array[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 4");
            array[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 5");
            array[5] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 6");
            array[6] = Convert.ToInt32(Console.ReadLine());
            int S = (array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6])/7;
            Console.Write("Среднее арифметическое {0}", S);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
