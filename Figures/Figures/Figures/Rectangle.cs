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

        public Rectangle(int side1, int side2, int number)
        {
            Number = number;
            this.side1 = side1;
            this.side2 = side2;
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
