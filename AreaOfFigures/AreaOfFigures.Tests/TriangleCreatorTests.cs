using AreaOfFigures.Entities.Figures;
using AreaOfFigures.Infrastructure.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Tests
{
    public class TriangleCreatorTests
    {
        [Fact]
        public void CreateResultIsTriangle()
        {
            // Arrange
            TriangleCreator creator = new TriangleCreator();

            // Act
            var result = creator.Create(2, 3, 4);

            // Assert
            Assert.IsType<Triangle>(result);
        }
        [Fact]
        public void CreateResultNotNull()
        {
            // Arrange
            TriangleCreator creator = new TriangleCreator();

            // Act
            Triangle result = creator.Create(2, 3, 4);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void CreateResultIsNullParamIsZero()
        {
            // Arrange
            TriangleCreator creator = new TriangleCreator();

            // Act
            Triangle result = creator.Create(0, 2, 3);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void CreateResultIsNullParamIsNegative()
        {
            // Arrange
            TriangleCreator creator = new TriangleCreator();

            // Act
            Triangle result = creator.Create(-1, 2, 3);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void CreateResultIsNullParamAIsBiggerSumBAndC()
        {
            // Arrange
            TriangleCreator creator = new TriangleCreator();

            // Act
            Triangle result = creator.Create(6, 2, 3);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void CreateTriangleIsRectangular()
        {
            // Arrange
            TriangleCreator creator = new TriangleCreator();

            // Act
            Triangle firstTriangle = creator.Create(3, 1, Math.Sqrt(10));
            Triangle secondTriangle = creator.Create(Math.Sqrt(10), 1, 3);
            Triangle thirdTriangle = creator.Create(1, Math.Sqrt(10), 3);

            // Assert
            Assert.True(firstTriangle.IsRectangularTriangle);
            Assert.True(secondTriangle.IsRectangularTriangle);
            Assert.True(thirdTriangle.IsRectangularTriangle);
        }
        [Fact]
        public void CreateTriangleIsNotRectangular()
        {
            // Arrange
            TriangleCreator creator = new TriangleCreator();

            // Act
            Triangle firstTriangle = creator.Create(3, 1, 3.5);
            Triangle secondTriangle = creator.Create(3.5, 1, 3);
            Triangle thirdTriangle = creator.Create(1, 3.5, 3);

            // Assert
            Assert.False(firstTriangle.IsRectangularTriangle);
            Assert.False(secondTriangle.IsRectangularTriangle);
            Assert.False(thirdTriangle.IsRectangularTriangle);
        }
    }
}
