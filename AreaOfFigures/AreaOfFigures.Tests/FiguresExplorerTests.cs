using AreaOfFigures.Entities.Figures;
using AreaOfFigures.Infrastructure.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Tests
{
    public class FiguresExplorerTests
    {
        [Fact]
        public void GetAreaOfFigureResultIsValue()
        {
            // Arrange
            FiguresExplorer explorer = new FiguresExplorer();

            // Act
            double firstResult = explorer.GetAreaOfFigure(2);
            double secondResult = explorer.GetAreaOfFigure(3, 4, 5);

            // Assert
            Assert.Equal(12.566370614359172, firstResult);
            Assert.Equal(6, secondResult);
        }
        [Fact]
        public void GetAreaOfFigureResultIsMinusOne()
        {
            // Arrange
            FiguresExplorer explorer = new FiguresExplorer();

            // Act
            double firstReult = explorer.GetAreaOfFigure(2, 1);
            double secondReult = explorer.GetAreaOfFigure(-3, 4, 5);
            double thirdReult = explorer.GetAreaOfFigure(0);

            // Assert
            Assert.Equal(-1, firstReult);
            Assert.Equal(-1, secondReult);
            Assert.Equal(-1, thirdReult);
        }
    }
}
