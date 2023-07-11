using AreaOfFigures.Entities.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Infrastructure.Creators
{
    public class CircleCreator
    {
        public virtual Circle Create(double radius)
        {
            if (radius <= 0) return null;
            Circle result = new Circle() { Radius = radius };
            SetArea(result);
            return result;
        }
        protected virtual void SetArea(Circle circle)
        {
            circle.Area = Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}
