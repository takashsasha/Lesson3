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

            string[,] Massive =
            {
    {"Имя1", "Номер1"},
    {"Имя2", "Номер2"},
    {"Имя3", "Номер3"},
    {"Имя4", "Номер4"},
    {"Имя5", "Номер5"}
};
            Console.WriteLine("Выводим наш телефонный справочник:");
            for (int i = 0; i < Massive.GetLength(0); i++)
            {
                for (int j = 0; j < Massive.GetLength(1); j++)
                {
                    Console.Write($"{Massive[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
