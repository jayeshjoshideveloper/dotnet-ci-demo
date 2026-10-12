using Xunit;
using CalculatorLibrary = Calculator.Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(10, 20, 30)]
    [InlineData(-2, 2, 0)]
    public void Add_ReturnsExpectedResult(int a, int b, int expected)
    {
        var calculator = new CalculatorLibrary();

        var result = calculator.Add(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_ReturnsExpectedResult()
    {
        var calculator = new CalculatorLibrary();

        var result = calculator.Subtract(10, 5);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ReturnsExpectedResult()
    {
        var calculator = new CalculatorLibrary();

        var result = calculator.Multiply(4, 5);

        Assert.Equal(20, result);
    }

    [Fact]
    public void Add_ShouldFail_WhenExpectedResultIsIncorrect()
    {
        var calculator = new CalculatorLibrary();

        var result = calculator.Add(2, 3);

        Assert.Equal(10, result);
    }
}