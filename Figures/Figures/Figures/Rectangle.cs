using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            Thread.Sleep(1);
        }

        public override string Verification()
        {
            if (side1 == side2)
            {
                return "Квадрат";
            }
            else
            {
                return "Прямоугольник";
            }
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
                Console.Write("{0}  {1,5}  {2,10} ", Number, Verification(), side1);
                Console.Write("{0,11:0.####} ", Perimetr());
                Console.Write("{0,10:0.####} ", Square());
                Console.WriteLine("{0,18}", Verification().Equals("Квадрат"));
            }
            else
            {
                Console.Write("{0}  {1,5}  {2,4},", Number, Verification(), side1);
                Console.Write("{0} ", side2);
                Console.Write("{0,10:0.####} ", Perimetr());
                Console.Write("{0,10:0.####} ", Square());
                Console.WriteLine("{0,18}", Verification().Equals("Квадрат"));
            }
        }
    }
}
