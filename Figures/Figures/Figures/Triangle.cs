using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
                Thread.Sleep(1);
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
                Console.Write("{0} {1} {2,3},{3},{4} ", Number, Verification(), side1, side2, side3);
                Console.Write("{0,12:0.####} ", Perimetr());
                Console.Write("{0,10:0.####} ", Square());
                Console.WriteLine("{0,13}", Verification().Equals("Равносторонний"));
            }
            else
                Console.WriteLine("Треугольник не существует");
        }
    }
}
