using AreaOfFigures.Entities.Figures;
using AreaOfFigures.Infrastructure.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Infrastructure.Creators
{
    internal class FigureCreator
    {
        private CircleCreator circleCreator;
        private TriangleCreator triangCreator;
        public FigureCreator() 
        {
            circleCreator = new CircleCreator();
            triangCreator = new TriangleCreator();
        }
        public virtual Figure Create(params double[] sizeOfSides)
        {
            Figure figure = null;
            if (sizeOfSides.Length == 1)
            {
                figure = circleCreator.Create(sizeOfSides[0]);
            }
            else if (sizeOfSides.Length == 3) figure = triangCreator.Create(sizeOfSides[0],
                                                                                sizeOfSides[1],
                                                                                sizeOfSides[2]);
            return figure;
        }
    }
}
