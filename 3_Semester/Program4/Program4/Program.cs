using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program4
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            while (arr[0] == arr[1])
            {
                arr[1] = rnd.Next(1, 10);
            }
        m1: for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[j] *= j;
                        count++;
                    }
                    if (count == 1)
                        goto m1;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Хотите повторить? 1 - Да, 0 - Нет");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p == 1) Main();
            return;
        }
    }
}