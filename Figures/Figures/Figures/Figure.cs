using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public abstract class Figure
    {
        protected Random random = new Random();

        public abstract string Verification();

        public abstract double Perimetr();

        public abstract double Square();

        public abstract void GetInfo();

        public int CompareTo(object obj)
        {
            int index = Perimetr().CompareTo(((Figure)obj).Perimetr());
            return index;
        }
    }
}
