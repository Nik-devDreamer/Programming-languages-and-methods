using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Заполнить квадратную матрицу не повторяющимися элементами и проверить, является ли она магическим квадратом");
            int Count = 0;
        m1: Random rnd = new Random();
            int size, elemCount, i = 0, count = 0, flag = 1;
            int[] arr = new int[i];
            Console.Write("Введите размерность: ");
            size = 3;//Int32.Parse(Console.ReadLine());
            elemCount = size * size;
            if (size < 2)
            {
                Console.WriteLine("Размерность матрицы должна быть >= 2");
                goto m1;
            }
            int[,] matrix = new int[size, size];
            for (i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int random = rnd.Next(1, elemCount + 1);
                    for (int m = 0; m < size; m++)
                        for (int n = 0; n < size; n++)
                            if (random != matrix[m, n])
                                count++;
                    if (count == elemCount)
                    {
                        matrix[i, j] = random;
                        count = 0;
                    }
                    else
                    {
                        count = 0;
                        j = (j - 1);
                        continue;
                    }
                }
            }
            int[] arr2 = new int[2 * size + 2];
            int k = 0;
            for (i = 0; i < size; i++)
            {
                int str = 0, stb = 0;
                for (int j = 0; j < size; j++)
                {
                    str += matrix[i, j];
                    stb += matrix[j, i];
                }
                Console.WriteLine("Сумма элементов {0} строки: {1}", i + 1, str);
                Console.WriteLine("Сумма элементов {0} столбца: {1}", i + 1, stb);
                arr2[k++] = str;
                arr2[k++] = stb;
            }
            Console.WriteLine();
            int glav = 0, pob = 0;
            for (int j = 0; j < size; j++)
            {
                glav += matrix[j, j];
                pob += matrix[j, (size - j - 1)];
            }
            Console.WriteLine("Сумма елемeнтов главной диагонали равна: " + glav);
            Console.WriteLine("Сумма елемeнтов побочной диагонали равна: " + pob);
            arr2[2 * size] = glav;
            arr2[2 * size + 1] = pob;
            for (i = 1; i < arr2.Length; i++)
                if (arr2[0] != arr2[i])
                    flag = 0;
            Console.WriteLine("Вывод матрицы: ");
            for (i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            if (flag == 0)
                Console.WriteLine("Матрица не является магическим квадратом");
            else
                Console.WriteLine("Матрица является магическим квадратом");
            if (flag == 0)
            {
                Count++;
                goto m1;
            }
            Console.WriteLine("Попыток найти магический квадрат = " + Count);

            Console.WriteLine("Хотите повторить? 1 - Да, 0 - Нет");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p == 1) Main();
            return;
        }
    }
}