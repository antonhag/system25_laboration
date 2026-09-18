using Y2015D01Console;

namespace Y2015D01.Tests;

public class FloorFinderTests
{
    /*
 * (()) and ()() both result in floor 0.
   ((( and (()(()( both result in floor 3.
   ))((((( also results in floor 3.
   ()) and ))( both result in floor -1 (the first basement level).
   ))) and )())()) both result in floor -3.
 */

    [Fact]
    public void FindCorrectFloor_WhenGivenDirection_ReturnFloorZero()
    {
        // Arrange
        var sut = new FloorFinder();
        var expected = 0;
        var input = "(())";

        // Act
        var actual = sut.FindCorrectFloor(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindCorrectFloor_WhenGivenDirection_ReturnFloorThree()
    {
        // Arrange
        var sut = new FloorFinder();
        var expected = 3;

        // Act
        var actual = sut.FindCorrectFloor("(((");

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindCorrectFloor_WhenGivenDirection_ReturnFloorMinusOne()
    {
        // Arrange
        var sut = new FloorFinder();
        var expected = -1;
        
        // Act
        var actual = sut.FindCorrectFloor("())");

        // Assert
        Assert.Equal(expected, actual);   
    }

    [Theory]
    [InlineData("()())", -1)]
    [InlineData("))(((((", 3)]
    [InlineData("())", -1)]
    [InlineData(")))", -3)]
    public void FindCorrectFloor_WhenGivenDifferentDirections_ShouldReturnExpected(string directionGiven, int expected)
    {
        // Arrange
        var sut = new FloorFinder();

        // Act
        var actual = sut.FindCorrectFloor(directionGiven);

        // Assert
        Assert.Equal(expected, actual);  
    }

    [Fact]
    public void FindFloor_WhenGivenDirection_ShouldReturnIndexFive()
    {
        // Arrange
        var sut = new FloorFinder();
        var directionGiven = "()())";
        var expected = 5;
        
        // Act
        var actual = sut.FindBasementFloor(directionGiven);

        // Assert
        Assert.Equal(expected, actual); 
    }

    [Fact]
    public void FindFloor_WhenGivenDirection_ShouldReturnIndex2()
    {
        // Arrange
        var sut = new FloorFinder();
        var directionGiven = "())";
        var expected = 3;

        // Act
        var actual = sut.FindBasementFloor(directionGiven);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("()())", 5)]
    [InlineData("((())))", 7)]
    [InlineData(")", 1)]
    public void FindFloor_WhenGivenMultipleDirections_ShouldReturnExpected(string directionGiven, int expected)
    {
        // Arrange
        var sut = new FloorFinder();

        // Act
        var actual = sut.FindBasementFloor(directionGiven);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    
    
}