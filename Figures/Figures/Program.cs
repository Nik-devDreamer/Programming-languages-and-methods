using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgramFigures.Figures;

namespace ProgramFigures
{
    class Program
    {
        static void Main()
        {
            bool verification;
            int InputData;
            do
            {
                verification = true;
                Console.WriteLine("Вв-те номер фигуры, которая вам необходима");
                try
                {
                    Console.WriteLine("1 - Прямоугольник;\n2 - Круг;\n3 - Треугольник\nДругая цифра - выход.");
                    InputData = Convert.ToInt32(Console.ReadLine());
                    if (InputData == 1)
                    {
                        Rectangle rectangle = new Rectangle();
                    }
                    else if (InputData == 2)
                    {
                        Ellipse ellipse = new Ellipse();
                    }
                    else if (InputData == 3)
                    {
                        Triangle triangle = new Triangle();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Хотите повторить?\n1 - Да;\nДругое число - Нет");
                    var check = int.Parse(Console.ReadLine());
                    if (check == 1)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        verification = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Это не число\n");
                    Console.WriteLine();
                    Main();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Main();
                }
            } while (verification == true);
        }
    }
}
