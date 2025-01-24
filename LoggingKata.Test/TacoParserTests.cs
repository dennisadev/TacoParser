using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.524131,-86.724876,Taco Bell Birmingham...", -86.724876)]
        [InlineData("34.825527,-87.644081,Taco Bell Florence...", -87.644081)]
        [InlineData("30.449122,-84.306815,Taco Bell Tallahassee...", -84.306815)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.524131,-86.724876,Taco Bell Birmingham...", 33.524131)]
        [InlineData("34.825527,-87.644081,Taco Bell Florence...", 34.825527)]
        [InlineData("30.449122,-84.306815,Taco Bell Tallahassee...", 30.449122)]
        public void ShouldParseLatitude(string line, double expected) 
        {
            //Arannge
            var tacoParser = new TacoParser();
            
            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
