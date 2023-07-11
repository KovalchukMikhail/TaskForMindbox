using AreaOfFigures.Entities.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Infrastructure.Creators
{
    /// <summary>Класс содержит методы для создания объекта Circle</summary>
    public class CircleCreator
    {
        /// <summary>Данный метод создает объект Circle</summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Возвращаемый тип Circle. Если в качестве параметров передано значение меньше или равное 0 возвращается null</returns>
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
