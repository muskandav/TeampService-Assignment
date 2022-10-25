using NUnit.Framework;
using TempService;

namespace TempServices.Test
{
    [TestFixture]
    public class Nunit
    {
        [Test]

        public void CelsiusToFahrenheit()
        {
            //Arrange
            double celTemp = 40.8;

            //Act
            var result = Temp.CTF(celTemp);

            //Assert
            Assert.AreEqual(result, 105.44);
        }

        [Test]
        public void FahrenheitToCelsius()
        {
            //Arrange
            double FahTemp = 104;

            //Act
            var result = Temp.FTC(FahTemp);

            //Assert
            Assert.AreEqual(result, 40);
        }
    }
}