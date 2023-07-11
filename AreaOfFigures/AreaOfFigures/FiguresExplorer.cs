using AreaOfFigures.Entities.Figures;
using AreaOfFigures.Infrastructure.Creators;
using Microsoft.Extensions.DependencyInjection;

namespace AreaOfFigures
{
    public class FiguresExplorer : IFiguresExplorer
    {
        private FigureCreator figureCreator;
        /// <summary>Свойство содержит ссылку на последнюю фигуру площадь которой была определена в методе GetAreaOfFigure</summary>
        public Figure CurrentFiggure { get; set; } = null;
        public FiguresExplorer()
        {
            figureCreator = new FigureCreator();
        }
        /// <summary>Данный метод создает возвращает площадь фигуры на основании переданных данных</summary>
        /// <param name="sizeOfSides">Параметры фигуры радиус или размеры сторон</param>
        /// <returns>Возвращаемый тип double. Если переданные параметры не соответсвуют типам Circle или Triangl возвращается -1</returns>
        public double GetAreaOfFigure(params double[] sizeOfSides)
        {
            Figure figure = figureCreator.Create(sizeOfSides);
            if (figure != null)
            {
                CurrentFiggure = figure;
                return CurrentFiggure.Area;
            }
            else return -1;
        }
    }
}