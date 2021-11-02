using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramFigures.Figures
{
    public class Figures : IEnumerable
    {
        public List<Figures> figures = new List<Figures>();

        public IEnumerator GetEnumerator()
        {
            return figures.GetEnumerator();
        }

        public void Addition(Figures figure)
        {
            figures.Add(figure);
        }
    }
}
