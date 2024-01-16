using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1p2
{
    internal class Program
    {
        // Дана целочисленная прямоугольная матрица.
        // 1) Определить количество столбцов, содержащих хотя бы один нулевой элемент
        // 2) Определить номер строки, в которой находится самая длинная серия одинаковых элементов.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов: ");
            int M = int.Parse(Console.ReadLine());
            int[,] Matr = new int[N, M];
            Part2.InputMatrix(ref Matr);
            Part2.DisplayMatrix(ref Matr);
            Console.WriteLine($"Количество столбцов, содержащих хотя бы один нулевой элемент: {Part2.GetZeroColumns(ref Matr)}");
            Console.WriteLine($"Номер строки, в которой находится самая длинная серия одинаковых элементов: {Part2.GetRowWithMaxSeries(ref Matr)}");
            Console.ReadLine();
        }
    }
}
