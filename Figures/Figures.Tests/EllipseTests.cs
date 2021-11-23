using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xunit;
using ProgramFigures.Figures;

namespace Figures.Tests
{
    public class EllipseTests
    {
        [Fact]
        public void Generation_of_1000_Objects()
        {
            //Arrange

            var rand = new Random();
            Stopwatch sw = new Stopwatch();

            //Act

            sw.Start();

            for (int i = 0; i < 1000; i++)
            {
                Ellipse ellipse = new Ellipse(rand.Next(1, 4), rand.Next(1, 4), i + 1);
                ellipse.GetHashCode();
            }

            sw.Stop();

            //Assert

            Assert.InRange(sw.ElapsedMilliseconds, 0, 60000);
        }

        [Fact]
        public void Generation_of_10000_Objects()
        {
            //Arrange

            var rand = new Random();
            Stopwatch sw = new Stopwatch();

            //Act

            sw.Start();

            for (int i = 0; i < 10000; i++)
            {
                Ellipse ellipse = new Ellipse(rand.Next(1, 4), rand.Next(1, 4), i + 1);
                ellipse.GetHashCode();
            }

            sw.Stop();

            //Assert

            Assert.InRange(sw.ElapsedMilliseconds, 0, 60000);
        }

        [Fact]
        public void Generation_of_100000_Objects()
        {
            //Arrange

            var rand = new Random();
            Stopwatch sw = new Stopwatch();

            //Act

            sw.Start();

            for (int i = 0; i < 100000; i++)
            {
                Ellipse ellipse = new Ellipse(rand.Next(1, 4), rand.Next(1, 4), i + 1);
                ellipse.GetHashCode();
            }

            sw.Stop();

            //Assert

            Assert.InRange(sw.ElapsedMilliseconds, 0, 60000);
        }

        [Fact]
        public void Generation_of_1000000_Objects()
        {
            //Arrange

            var rand = new Random();
            Stopwatch sw = new Stopwatch();

            //Act

            sw.Start();

            for (int i = 0; i < 1000000; i++)
            {
                Ellipse ellipse = new Ellipse(rand.Next(1, 4), rand.Next(1, 4), i + 1);
                ellipse.GetHashCode();
            }

            sw.Stop();

            //Assert

            Assert.InRange(sw.ElapsedMilliseconds, 0, 60000);
        }
    }
}
