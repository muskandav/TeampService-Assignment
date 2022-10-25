

using TempService;
using Xunit;

namespace TempServices.Test
{
    public class Xunit
    {
        [Fact]
        public void CelsiusToFahrenheit()
        {
            //Arrange
            double celTemp = 40.8;

            //Act
            var result = Temp.CTF(celTemp);

            //Assert
            Assert.Equal(result, 105.44);
        }

        [Fact]
        public void FahrenheitToCelsius()
        {
            //Arrange
            double FahTemp = 104;

            //Act
            var result = Temp.FTC(FahTemp);

            //Assert
            Assert.Equal(result, 40);
        }
    }
}
