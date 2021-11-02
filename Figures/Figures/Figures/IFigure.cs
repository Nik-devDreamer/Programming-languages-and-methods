using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public interface IFigure
    {
        string Verification();

        double Perimetr();

        double Square();

        void GetInfo();
    }
}
