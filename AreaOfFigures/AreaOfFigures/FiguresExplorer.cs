using AreaOfFigures.Entities.Figures;
using AreaOfFigures.Infrastructure.Creators;
using Microsoft.Extensions.DependencyInjection;

namespace AreaOfFigures
{
    public class FiguresExplorer : IFiguresExplorer
    {
        private FigureCreator figureCreator;
        public Figure CurrentFiggure { get; set; } = null;
        public FiguresExplorer()
        {
            figureCreator = new FigureCreator();
        }
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