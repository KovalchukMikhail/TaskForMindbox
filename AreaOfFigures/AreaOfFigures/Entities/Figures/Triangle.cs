using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Entities.Figures
{
    public class Triangle : Figure
    {
        internal Triangle() { }
        public double SizeOfSideA { get; internal set; }
        public double SizeOfSideB { get; internal set; }
        public double SizeOfSideC { get; internal set; }
        public bool IsRectangularTriangle { get; internal set; }
        public override string ToString()
        {
            return "Треугольник";
        }
    }
}
