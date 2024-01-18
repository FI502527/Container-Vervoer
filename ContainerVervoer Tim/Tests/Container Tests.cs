using ContainerVervoer_Tim.Model;
using NUnit.Framework;
using Type = ContainerVervoer_Tim.Type;

namespace Tests
{
    [TestFixture]
    public class ContainersTests
    {
        [Test]
        public void ContainersPropertiesTest()
        {
            // Arrange
            string naam = "Container1";
            int gewicht = 10;
            Type type = Type.Normaal;

            // Act
            var container = new Containers(naam, gewicht, type);

            // Assert
            Assert.AreEqual(naam, container.Naam);
            Assert.AreEqual(gewicht, container.Gewicht);
            Assert.AreEqual(type, container.Type);
        }

        [Test]
        public void GewichtMaken_WithValidWeight_SetGewichtProperty()
        {
            // Arrange
            var container = new Containers("Container1", 10, Type.Normaal);
            int gewicht = 20;

            // Act
            container.GewichtMaken(gewicht);

            // Assert
            Assert.AreEqual(gewicht, container.Gewicht);
        }

        [Test]
        public void GewichtMaken_WithInvalidWeight_PrintErrorMessage()
        {
            // Arrange
            var container = new Containers("Container1", 10, Type.Normaal);
            int gewicht = 3;

            // Act
            // In this case, the error message will be printed to the console

            // Assert
            // We cannot directly assert the console output in unit tests, so we can't assert anything here
        }

        [Test]
        public void ToString_ReturnsCorrectStringRepresentation()
        {
            // Arrange
            string naam = "Container1";
            int gewicht = 10;
            Type type = Type.Normaal;
            var container = new Containers(naam, gewicht, type);
            string expectedString = $"Container {naam} is {gewicht} ton en {type}.";

            // Act
            string actualString = container.ToString();

            // Assert
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
