using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public class Rectangle : Figure
    {
        public int Number { get; set; }
        public int side1 { get; set; }
        public int side2 { get; set; }

        public Rectangle(int number)
        {
            Number = number;
            side1 = random.Next(1, 4);
            side2 = random.Next(1, 4);
            Console.ReadKey();
        }

        public override string Verification()
        {
            if (side1 == side2)
                return "Квадрат";
            else
                return "Прямоугольнк";
        }

        public override double Perimetr()
        {
            return (side1 + side2) * 2;
        }

        public override double Square()
        {
            return side1 * side2;
        }

        public override void GetInfo()
        {
            if (Verification() == "Квадрат")
            {
                Console.Write("№{0} {1} Сторона = {2} ", Number, Verification(), side1);
            }
            else
            {
                Console.Write("№{0} {1} Первая сторона = {2} ", Number, Verification(), side1);
                Console.Write("Вторая сторона = {0} ", side2);
            }
            Console.Write("Периметр = {0:0.00} ", Perimetr());
            Console.WriteLine("Площадь = {0:0.00}", Square());
        }
    }
}
