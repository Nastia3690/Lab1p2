using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1p2
{
    public class Part2
    {
        //Определить количество столбцов, содержащих хотя бы один нулевой элемент
        public static int GetZeroColumns(ref int[,] Matr)
        {
            int res = 0;
            for (int j = 0; j < Matr.GetLength(1); j++)
            {
                for (int i = 0; i < Matr.GetLength(0); i++)
                {
                    if (Matr[i, j] == 0)
                    {
                        res++;
                        break;
                    }
                }
            }
            return res;
        }
        // Определить номер строки, в которой находится самая длинная серия одинаковых элементов.
        public static int GetRowWithMaxSeries(ref int[,] Matr)
        {
            int ind = -1;//индекс
            int num = -1;//число одинаковых элементов
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                int maxnum = 1;
                int curnum = 1;
                int prev = Matr[i, 0];
                for (int j = 1; j < Matr.GetLength(1); j++)
                {
                    if (Matr[i, j] != prev)//конец серии
                    {
                        if (curnum > maxnum)
                        {
                            maxnum = curnum;
                        }
                        curnum = 1;
                        prev = Matr[i, j];
                    }
                    else
                    {
                        curnum++;
                        if (j == Matr.GetLength(1) - 1)//конец серии
                        {
                            if (curnum > maxnum)
                            {
                                maxnum = curnum;
                            }
                        }
                    }
                }
                if (maxnum > num)
                {
                    ind = i;
                    num = maxnum;
                }
            }
            return ind+1;
        }
        // заполнение случаными числами
        public static void InputMatrix(ref int[,] Matr)
        {
            Random random = new Random(9);
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    Matr[i, j] = random.Next(9);//заполним случайными числами.
                }
            }
        }
        // вывод матрицы на экран
        public static void DisplayMatrix(ref int[,] Matr)
        {
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                String S = "";
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    S = S + Matr[i, j] + '\t';
                }
                Console.WriteLine(S);
            }
        }

    }
}
