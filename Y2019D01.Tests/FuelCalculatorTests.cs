namespace Y2019D01.Tests;

public class FuelCalculatorTests
{
    /*
     * For a mass of 12, divide by 3 and round down to get 4, then subtract 2 to get 2.
       For a mass of 14, dividing by 3 and rounding down still yields 4, so the fuel required is also 2.
       For a mass of 1969, the fuel required is 654.
       For a mass of 100756, the fuel required is 33583.
     */
    [Fact]
    public void CalculateFuel_WhenGivenMassTwelve_ShouldReturnTwo()
    {
        // Arrange
        var sut = new FuelCalculator();
        var mass = 12;
        var expected = 2;

        // Act
        var actual = sut.CalculateFuel(mass);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1969, 654)]
    [InlineData(100756, 33583)]
    public void CalculateFuel_WhenGivenLargeMasses_ShouldReturnExpected(int mass, int expected)
    {
        // Arrange
        var sut = new FuelCalculator();

        // Act
        var actual = sut.CalculateFuel(mass);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    /*
     * 654 + 216 + 70 + 21 + 5 = 966
     */
    // [Fact] 
    // public void CalculateAdvancedFuel_WhenCalculatedMultipleTimes_ShouldReturnCorrectValue()
    // {
    //     // Arrange
    //     var sut = new FuelCalculator();
    //     var mass = 1969;
    //     var expected = 966;
    //
    //     // Act
    //     var actual = sut.CalculateAdvancedFuel(mass);
    //
    //     // Assert
    //     Assert.Equal(expected, actual);
    // }
}