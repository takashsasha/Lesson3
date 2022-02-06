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

            Console.WriteLine("Морской бой");
            char[,] seaBattle =
            {
    {'X','X','X','O','X','X','O','O','O','X'},
    {'O','O','O','O','O','O','O','O','O','X'},
    {'X','X','O','X','O','O','X','X','O','X'},
    {'O','O','O','X','O','O','O','O','O','X'},
    {'O','O','O','X','O','O','O','O','O','O'},
    {'X','O','O','O','O','X','X','X','O','O'},
    {'X','O','X','O','O','O','O','O','O','O'},
    {'X','O','O','O','O','O','O','O','O','O'},
    {'X','O','O','O','X','X','X','O','O','X'},
    {'X','O','O','O','O','O','O','O','O','X'},
};
            //Вывод массива
            for (int i = 0; i < seaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < seaBattle.GetLength(1); j++)
                {
                    Console.Write($"{seaBattle[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
