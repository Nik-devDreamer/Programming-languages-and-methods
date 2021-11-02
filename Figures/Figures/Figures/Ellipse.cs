using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public class Ellipse : IFigure
    {
        public int radius1 { get; set; }
        public int radius2 { get; set; }

        public Ellipse()
        {
            Random random = new Random();
            radius1 = random.Next(1, 3);
            radius2 = random.Next(1, 3);
            GetInfo();
            Console.WriteLine();
        }

        public string Verification()
        {
            if (radius1 == radius2)
                return "Круг";
            else
                return "Эллипс";
        }

        public double Perimetr()
        {
            //Проверка на равенство радиусов
            if (radius1 == radius2)
            {
                return (2 * Math.PI * radius1);
            }
            else
            {
                return (2 * Math.PI * Math.Sqrt((radius1 * radius1 + radius2 * radius2) / 2));
            }
        }

        public double Square()
        {
            return (Math.PI * radius1 * radius2);
        }

        public void GetInfo()
        {
            if (Verification() == "Круг")
            {
                Console.WriteLine("Информация о круге: ");
                Console.WriteLine("Радиус круга = {0}", radius1);
            }
            else
            {
                Console.WriteLine("Информация о эллипсе: ");
                Console.WriteLine("Первый радиус эллипса = {0}", radius1);
                Console.WriteLine("Второй радиус эллипса = {0}", radius2);
            }
            Console.WriteLine("Периметр = {0}", Perimetr());
            Console.WriteLine("Площадь = {0}", Square());
        }
    }
}
