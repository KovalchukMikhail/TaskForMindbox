using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Entities.Figures
{
    public class Circle : Figure
    {
        internal Circle() { }
        public double Radius { get; internal set; }
        public override string ToString()
        {
            return "Круг";
        }
    }
}
