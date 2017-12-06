using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 1;

               Swap(ref a, ref b);

            Console.WriteLine("a={0}, b={1}", a, b);
        }
        /// <summary>
        /// Обмен значений переменных
        /// </summary>
        /// <param name="a">Первая переменная</param>
        /// <param name="b">Вторая переменная</param>
        private static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
