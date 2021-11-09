using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public class Triangle : Figure
    {
        public int Number { get; set; }
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        public Triangle(int number)
        {
            while (!(side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1))
            {
                Number = number;
                side1 = random.Next(1, 4);
                side2 = random.Next(1, 4);
                side3 = random.Next(1, 4);
                Console.ReadKey();
            }
        }

        public override string Verification()
        {
            if (side1 == side2 && side1 == side3)
            {
                return "Равносторонний";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Равнобедренный";
            }
            else
            {
                return "Разносторонний";
            }
        }

        public bool ExistenceCheck()
        {
            bool Check;
            if (side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1)
                Check = true;
            else
                Check = false;
            return Check;
        }

        public override double Perimetr()
        {
            return (double)(side1 + side2 + side3);
        }

        public override double Square()
        {
            double Semiperimeter;
            Semiperimeter = (side1 + side2 + side3) / 2;
            return (Math.Sqrt(Semiperimeter * (Semiperimeter - side1) * (Semiperimeter - side2) * (Semiperimeter - side3)));
        }

        public override void GetInfo()
        {
            if (ExistenceCheck() == true)
            {
                Console.Write("№{0} {1} Первая сторона = {2} Вторая сторона = {3} Третья сторона = {4} ", Number, Verification(), side1, side2, side3);
                Console.Write("Периметр = {0:0.00} ", Perimetr());
                Console.WriteLine("Площадь треугольника = {0:0.00}", Square());
            }
            else
                Console.WriteLine("Треугольник не существует");
        }
    }
}
