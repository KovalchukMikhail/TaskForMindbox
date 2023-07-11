using AreaOfFigures.Entities.Figures;
using AreaOfFigures.Infrastructure.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Tests
{
    public class CircleCreatorTests
    {
        [Fact]
        public void CreateResultIsCircle()
        {
            // Arrange
            CircleCreator creator = new CircleCreator();

            // Act
            var result = creator.Create(2);

            // Assert
            Assert.IsType<Circle>(result);
        }
        [Fact]
        public void CreateResultNotNull()
        {
            // Arrange
            CircleCreator creator = new CircleCreator();

            // Act
            Circle result = creator.Create(2);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void CreateResultIsNullParamIsZero()
        {
            // Arrange
            CircleCreator creator = new CircleCreator();

            // Act
            Circle result = creator.Create(0);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void CreateResultIsNullParamIsNegative()
        {
            // Arrange
            CircleCreator creator = new CircleCreator();

            // Act
            Circle result = creator.Create(-1);

            // Assert
            Assert.Null(result);
        }
    }
}
