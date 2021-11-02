using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public class Rectangle : IFigure
    {
        public int side1 { get; set; }
        public int side2 { get; set; }

        public Rectangle()
        {
            Random random = new Random();
            side1 = random.Next(1, 3);
            side2 = random.Next(1, 3);
            GetInfo();
            Console.WriteLine();
        }

        public string Verification()
        {
            if (side1 == side2)
                return "Квадрат";
            else
                return "Прямоугольнк";
        }

        public double Perimetr()
        {
            return (side1 + side2) * 2;
        }

        public double Square()
        {
            return side1 * side2;
        }

        public void GetInfo()
        {
            if (Verification() == "Квадрат")
            {
                Console.WriteLine("Информация о квадрате: ");
                Console.WriteLine("Сторона квадрата = {0}", side1);
            }
            else
            {
                Console.WriteLine("Информация о прямоугольнике: ");
                Console.WriteLine("Первая сторона прямоугольника = {0}", side1);
                Console.WriteLine("Вторая сторона прямоугольника = {0}", side2);
            }
            Console.WriteLine("Периметр = {0}", Perimetr());
            Console.WriteLine("Площадь = {0}", Square());
        }
    }
}
