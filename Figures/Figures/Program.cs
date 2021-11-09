using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using ProgramFigures.Figures;

namespace ProgramFigures
{
    class Program
    {
        static void Main()
        {
            int InputData, countFigure;
            List<Figure> figures = new List<Figure>();
            Random random = new Random();
            Figure figure;

            while (true)
            {
                Console.Write("Введите количество фигур: ");
                countFigure = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер фигуры, которая вам необходима");
                try
                {
                    Console.WriteLine("1 - Прямоугольник;\n2 - Круг;\n3 - Треугольник\nДругая цифра - выход.");
                    InputData = Int32.Parse(Console.ReadLine());
                    if (InputData == 1)
                    {
                        for (int i = 0; i < countFigure; i++)
                        {
                            figure = new Rectangle(i + 1);
                            figures.Add(figure);
                        }
                    }
                    else if (InputData == 2)
                    {
                        for (int i = 0; i < countFigure; i++)
                        {
                            figure = new Ellipse(i + 1);
                            figures.Add(figure);
                        }
                    }
                    else if (InputData == 3)
                    {
                        for (int i = 0; i < countFigure; i++)
                        {
                            figure = new Triangle(i + 1);
                            figures.Add(figure);
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Первоначальный список:");
                    foreach (Figure x in figures)
                    {
                        x.GetInfo();
                    }
                    Console.WriteLine();

                    figures.Sort((a, b) => a.Perimetr().CompareTo(b.Perimetr()));
                    IEnumerator IEnum = figures.GetEnumerator();

                    Console.WriteLine("Отсортированный список 'foreach'");
                    foreach (Figure x in figures)
                    {
                        x.GetInfo();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Отсортированный список 'while'");
                    while (IEnum.MoveNext())
                    {
                        figure = (Figure)IEnum.Current;
                        figure.GetInfo();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Хотите повторить?\n1 - Да;\nДругое число - Нет");
                    int g = int.Parse(Console.ReadLine());
                    if (g == 1)
                    {
                        Console.Clear();
                        Main();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Main();
                }
            }
        }
    }
}
