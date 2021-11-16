using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            Thread.Sleep(1);
        }

        public override string Verification()
        {
            if (radius1 == radius2)
            {
                return "Круг";
            }
            else
            {
                return "Эллипс";
            }
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
                Console.Write("{0}  {1,8}  {2,9} ", Number, Verification(), radius1);
                Console.Write("{0,15:0.####} ", Perimetr());
                Console.Write("{0,10:0.####} ", Square());
                Console.WriteLine("{0,12}", Verification().Equals("Круг"));
            }
            else
            {
                Console.Write("{0} {1,10} {2,8},", Number, Verification(), radius1);
                Console.Write("{0} ", radius2);
                Console.Write("{0,14:0.####} ", Perimetr());
                Console.Write("{0,9:0.####} ", Square());
                Console.WriteLine("{0,14}", Verification().Equals("Круг"));
            }
        }
    }
}
