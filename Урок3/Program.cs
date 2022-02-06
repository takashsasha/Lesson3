using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string m = Console.ReadLine();
            char[] chars = m.ToCharArray();
            Console.WriteLine("Ваша строка на оборот:");
            for (int i = chars.Length; i > 0; i--)
            {
                Console.Write(chars[i - 1]);
            }

            Console.ReadKey();

        }
    }
}
