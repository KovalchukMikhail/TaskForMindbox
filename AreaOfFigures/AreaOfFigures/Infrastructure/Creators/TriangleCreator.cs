using AreaOfFigures.Entities.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Infrastructure.Creators
{
    /// <summary>Класс содержит методы для создания объекта Triangle</summary>
    public class TriangleCreator
    {
        /// <summary>Данный метод создает объект Triangle</summary>
        /// <param name="sizeOfSideA">Размер стороны A треугольника</param>
        /// <param name="sizeOfSideB">Размер стороны B треугольника</param>
        /// <param name="sizeOfSideC">Размер стороны C треугольника</param>
        /// <returns>Возвращаемый тип Triangle. Если одна из сторон меньше или равна 0 или больше или равна сумме двух других сторон возвращается null</returns>
        public virtual Triangle Create(double sizeOfSideA, double sizeOfSideB, double sizeOfSideC)
        {
            if (sizeOfSideA <= 0
                || sizeOfSideB <= 0
                || sizeOfSideC <= 0
                || sizeOfSideA >= (sizeOfSideB + sizeOfSideC)
                || sizeOfSideB >= (sizeOfSideA + sizeOfSideC)
                || sizeOfSideC >= (sizeOfSideA + sizeOfSideB)) return null;
            Triangle triangle = new Triangle() { SizeOfSideA = sizeOfSideA, SizeOfSideB = sizeOfSideB, SizeOfSideC = sizeOfSideC };
            SetArea(triangle);
            triangle.IsRectangularTriangle = CheckIsRectangular(triangle);
            return triangle;
        }

        protected virtual void SetArea(Triangle triangle)
        {
            double p = (triangle.SizeOfSideA + triangle.SizeOfSideB + triangle.SizeOfSideC) / 2;
            triangle.Area = Math.Sqrt(p * (p - triangle.SizeOfSideA) * (p - triangle.SizeOfSideB) * (p - triangle.SizeOfSideC));
        }
        protected virtual bool CheckIsRectangular(Triangle triangle)
        {
            if(triangle.SizeOfSideA > triangle.SizeOfSideB && triangle.SizeOfSideA > triangle.SizeOfSideC)
            {
                return CompareSquareSides(triangle.SizeOfSideA, triangle.SizeOfSideB, triangle.SizeOfSideC);
            }
            else if (triangle.SizeOfSideB > triangle.SizeOfSideA && triangle.SizeOfSideB > triangle.SizeOfSideC)
            {
                return CompareSquareSides(triangle.SizeOfSideB, triangle.SizeOfSideA, triangle.SizeOfSideC);
            }
            else
            {
                return CompareSquareSides(triangle.SizeOfSideC, triangle.SizeOfSideA, triangle.SizeOfSideB);
            }
        }
        protected bool CompareSquareSides(double hypotenuse, double firstSide, double secondSide)
        {
            return Math.Round(Math.Pow(hypotenuse, 2), 5) == Math.Round(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2), 5);
        }
    }
}
