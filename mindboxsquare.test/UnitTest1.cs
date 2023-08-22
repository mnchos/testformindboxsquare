using libformindboxsquare;
namespace mindboxsquare.test
{
    public class GeometryCalculatorTests
    {
        [TestClass]
        public class ShapeTests
        {
            [TestMethod]
            public void Circle_CalculateArea_ValidRadius()
            {
                // Arrange
                double radius = 5;
                double expectedArea = Math.PI * radius * radius;
                IShape circle = new Circle(radius);

                // Act
                double actualArea = circle.CalculateArea();

                // Assert
                Assert.AreEqual(expectedArea, actualArea, 0.0001);
            }

            [TestMethod]
            public void Triangle_CalculateArea_ValidSides()
            {
                // Arrange
                double sideA = 3;
                double sideB = 4;
                double sideC = 5;
                double expectedArea = 6;
                IShape triangle = new Triangle(sideA, sideB, sideC);

                // Act
                double actualArea = triangle.CalculateArea();

                // Assert
                Assert.AreEqual(expectedArea, actualArea, 0.0001);
            }

            [TestMethod]
            public void Triangle_IsRightAngled_True()
            {
                // Arrange
                IShape triangle = new Triangle(3, 4, 5) as Triangle;

                // Act
                bool isRightAngled = (triangle as Triangle).IsRightAngled();

                // Assert
                Assert.IsTrue(isRightAngled);
            }

            [TestMethod]
            public void Triangle_IsRightAngled_False()
            {
                // Arrange
                IShape triangle = new Triangle(5, 7, 9) as Triangle;

                // Act
                bool isRightAngled = (triangle as Triangle).IsRightAngled();

                // Assert
                Assert.IsFalse(isRightAngled);
            }
        }
    }
}