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

                    /*
                    Console.WriteLine("Первоначальный список:");
                    Console.WriteLine("№     Фигура      Стороны     Периметр    Площадь    Равенство сторон");
                    foreach (Figure x in figures)
                    {
                        x.GetInfo();
                    }
                    Console.WriteLine();

                    figures.Sort((a, b) => a.Perimetr().CompareTo(b.Perimetr()));
                    IEnumerator IEnum = figures.GetEnumerator();

                    Console.WriteLine("Отсортированный список 'foreach'");
                    Console.WriteLine("№     Фигура      Стороны     Периметр    Площадь    Равенство сторон");
                    foreach (Figure x in figures)
                    {
                        x.GetInfo();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Отсортированный список 'while'");
                    Console.WriteLine("№     Фигура      Стороны     Периметр    Площадь    Равенство сторон");
                    while (IEnum.MoveNext())
                    {
                        figure = (Figure)IEnum.Current;
                        figure.GetInfo();
                    }
                    Console.WriteLine();
                    */

                    Console.WriteLine("Фигуры начинающиеся на букву 'П'");
                    foreach (Figure x in figures)
                    {
                        if (x.Verification().StartsWith("П"))
                            x.GetInfo();
                    }
                    Console.WriteLine();

                    var FiguresGroups = from figur in figures
                                        group figur by figur.Verification();
                    Console.WriteLine("№     Фигура      Стороны     Периметр    Площадь    Равенство сторон");
                    foreach (IGrouping<string, Figure> g in FiguresGroups)
                    {
                        foreach (Figure figuresGroups in g)
                        {
                            figuresGroups.GetInfo();
                        }
                    }
                    Console.WriteLine();

                    bool figuresAll = figures.All(x => x.Perimetr() > 5);
                    Console.WriteLine("Все периметры больше 5: " + figuresAll);

                    bool figuresAny = figures.Any(x => x.Square() > 5);
                    Console.WriteLine("Хотя бы одна площадь больше 5: " + figuresAny);

                    double figuresSum = figures.Sum(x => x.Square());
                    Console.WriteLine("Сумма всех площадей: " + figuresSum);

                    double figuresMin = figures.Min(x => x.Perimetr());
                    Console.WriteLine("Наименьший периметр: " + figuresMin);

                    double figuresMax = figures.Max(x => x.Square());
                    Console.WriteLine("Наибольшая площадь: " + figuresMax);
                    Console.WriteLine();




                    Console.WriteLine("Хотите повторить?\n1 - Да;\nДругое число - Нет");
                    int s = int.Parse(Console.ReadLine());
                    if (s == 1)
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
