namespace Kros.Mutation.Tests;

public class CalculatorShould
{
    private readonly Calculator _calculator = new Calculator();

    [Theory]
    [InlineData(100, 0, 100)]
    public void Addition_Returns_ExpectedResult(int a, int b, int expectedResult)
    {
        var result = _calculator.Add(a, b);
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(30, 0, 30)]
    public void Subtraction_Returns_ExpectedResult(int a, int b, int expectedResult)
    {
        var result = _calculator.Subtract(a, b);
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 1, 2)]
    public void Multiply_Returns_ExpectedResult(int a, int b, int expectedResult)
    {
        var result = _calculator.Multiply(a, b);
        result.Should().Be(expectedResult);
    }
}