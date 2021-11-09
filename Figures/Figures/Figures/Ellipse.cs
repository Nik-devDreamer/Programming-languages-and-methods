using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public class Ellipse : Figure
    {
        public int Number { get; set; }
        public int radius1 { get; set; }
        public int radius2 { get; set; }

        public Ellipse(int number)
        {
            Number = number;
            radius1 = random.Next(1, 4);
            radius2 = random.Next(1, 4);
            Console.ReadKey();
        }

        public override string Verification()
        {
            if (radius1 == radius2)
                return "Круг";
            else
                return "Эллипс";
        }

        public override double Perimetr()
        {
            if (radius1 == radius2)
            {
                return (2 * Math.PI * radius1);
            }
            else
            {
                return (2 * Math.PI * Math.Sqrt((radius1 * radius1 + radius2 * radius2) / 2));
            }
        }

        public override double Square()
        {
            return (Math.PI * radius1 * radius2);
        }

        public override void GetInfo()
        {
            if (Verification() == "Круг")
            {
                Console.Write("№{0} {1} Радиус = {2} ", Number, Verification(), radius1);
            }
            else
            {
                Console.Write("№{0} {1} Первый радиус = {0} ", Number, Verification(), radius1);
                Console.Write("Второй радиус = {0} ", radius2);
            }
            Console.Write("Периметр = {0:0.00} ", Perimetr());
            Console.WriteLine("Площадь = {0:0.00}", Square());
        }
    }
}
