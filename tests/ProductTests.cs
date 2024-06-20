using NUnit.Framework;
using Trabalhob2;

namespace Trabalhob2Tests
{
    public class ProductTests
    {
        [Test]
        public void TestCalculatePrice_AgriculturalProduct_Quantity50()
        {
            // Arrange
            Product coffe = new AgriculturalProduct("Coffe", 2.0, 50);

            // Act
            double finalPrice = coffe.calculatePrice();

            // Assert
            Assert.AreEqual(109.0, finalPrice, 0.01);
        }

        [Test]
        public void TestCalculatePrice_AgriculturalProduct_Quantity150()
        {
            // Arrange
            Product coffe = new AgriculturalProduct("Coffe", 2.0, 150);

            // Act
            double finalPrice = coffe.calculatePrice();

            // Assert
            Assert.AreEqual(327.0, finalPrice, 0.01);
        }

        [Test]
        public void TestCalculateFinalPrice_IndustrializedProduct_Quantity100()
        {
            // Arrange
            Product chips = new IndustrializedProduct("Chips", 500, 100);

            // Act
            double finalPrice = chips.calculateFinalPrice();

            // Assert
            Assert.AreEqual(67275.0, finalPrice, 0.01);
        }
    }
}
