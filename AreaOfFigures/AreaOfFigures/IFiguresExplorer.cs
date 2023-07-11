using AreaOfFigures.Entities.Figures;
using AreaOfFigures.Infrastructure.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public interface IFiguresExplorer
    {
        public Figure CurrentFiggure { get; protected set; }
        public double GetAreaOfFigure(params double[] sizeOfSides);
    }
}
