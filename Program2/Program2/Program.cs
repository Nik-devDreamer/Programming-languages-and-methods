using System;
using System.Collections.Generic;
using System.Linq;

namespace Program2
{
    public class Program
    {
        static int MinRow(int[,] arr, int i, int a)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                if (arr[i, j] < a)
                    return 0;
            return 1;
        }

        static int MaxColumn(int[,] arr, int j, int a)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                if (arr[i, j] > a)
                    return 0;
            return 1;
        }

        public static void Main()
        {
            int n = 3, m = 4, count = 0;
            Random rnd = new Random();
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 11);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0, 3}", arr[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (MinRow(arr, i, arr[i, j]) == 1 && MaxColumn(arr, j, arr[i, j]) == 1)
                    {
                        Console.WriteLine("Седловая точка: [{0}, {1}] = {2}", i, j, arr[i, j]);
                        count++;
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("Седловых точек нет");

            Console.WriteLine("Хотите повторить? 1 - Да, 0 - Нет");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p == 1) Main();
            return;
        }
    }
}