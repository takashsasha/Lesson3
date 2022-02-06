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
            
            int[,] Massive =
            {
    { 1,2,3,4},
    { 5,6,7,8},
    { 9,10,11,12},
    { 13,14,15,16}   
};
            Console.WriteLine("Выводим наш массив:");
            for (int i = 0; i < Massive.GetLength(0); i++)
            {
                for (int j = 0; j < Massive.GetLength(1); j++)
                {
                    Console.Write($"{Massive[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Выводим элементы двумерного массива по диагонали");
            int diagonal = 0;
            for (int i = 0; i < Massive.GetLength(0); i++)
            {
                for (int j = 0; j < Massive.GetLength(1); j++)
                {
                    diagonal++;
                    Console.WriteLine($"{new string(' ', diagonal)}{Massive[i, j]}");
                }
            }
            Console.ReadLine();

        }
    }
}
