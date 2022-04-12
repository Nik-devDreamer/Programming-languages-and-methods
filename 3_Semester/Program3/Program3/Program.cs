using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3
{
    class Program
    {
        static void Main()
        {
            int m = 4;
            int n = 3;
            int s = 1;
            int[,] array = new int[m, n];

            for (int y = 0; y < n; y++)
            {
                array[0, y] = s;
                s++;
            }
            for (int x = 1; x < m; x++)
            {
                array[x, n - 1] = s;
                s++;
            }
            for (int y = n - 2; y >= 0; y--)
            {
                array[m - 1, y] = s;
                s++;
            }
            for (int x = m - 2; x > 0; x--)
            {
                array[x, 0] = s;
                s++;
            }

            int c = 1;
            int d = 1;

            while (s < m * n)
            {
                //Движемся вправо.
                while (array[c, d + 1] == 0)
                {
                    array[c, d] = s;
                    s++;
                    d++;
                }
                //Движемся вниз.
                while (array[c + 1, d] == 0)
                {
                    array[c, d] = s;
                    s++;
                    c++;
                }
                //Движемся влево.
                while (array[c, d - 1] == 0)
                {
                    array[c, d] = s;
                    s++;
                    d--;
                }
                //Движемся вверх.
                while (array[c - 1, d] == 0)
                {
                    array[c, d] = s;
                    s++;
                    c--;
                }
            }

            for (int x = 0; x < m; x++)
                for (int y = 0; y < n; y++)
                    if (array[x, y] == 0)
                        array[x, y] = s;

            //Вывод
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                    Console.Write("{0, 4}", array[x, y]);
                Console.WriteLine();
            }

            Console.WriteLine("Хотите повторить? 1 - Да, 0 - Нет");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p == 1) Main();
            return;
        }
    }
}