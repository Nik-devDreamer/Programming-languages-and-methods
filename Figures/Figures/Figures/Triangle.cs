using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public class Triangle : IFigure
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        public Triangle()
        {
            Random random = new Random();
            side1 = random.Next(1, 10);
            side2 = random.Next(1, 10);
            side3 = random.Next(1, 10);
            GetInfo();
            Console.WriteLine();
        }

        public string Verification()
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

        public double Perimetr()
        {
            return (double)(side1 + side2 + side3);
        }

        public double Square()
        {
            double Semiperimeter;
            Semiperimeter = (side1 + side2 + side3) / 2;
            return (Math.Sqrt(Semiperimeter * (Semiperimeter - side1) * (Semiperimeter - side2) * (Semiperimeter - side3)));
        }

        public void GetInfo()
        {
            if (ExistenceCheck() == true)
            {
                Console.WriteLine("Информация о треугольнике:");
                Console.WriteLine("Вид треугольника:{0}", Verification());
                Console.WriteLine("Периметр треугольника:{0}", Perimetr());
                Console.WriteLine("Площадь треугольника:{0}", Square());
            }
            else
                Console.WriteLine("Треугольник не существует");
        }
    }
}
