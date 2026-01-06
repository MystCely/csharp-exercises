namespace CalculatorUnitTesting.Test;

public class CalculatorTests
{
    private Calculator _calculator;
    
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.LeggSammen(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract_ReturnCorrectSum()
    {
        var result = _calculator.TrekkFra(7, 5);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Multiply_ReturnCorrectSum()
    {
        var result = _calculator.Multipliser(5, 4);
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Divide_ReturnCorrectSum()
    {
        var result = _calculator.Divider(6, 3);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Check_SecNum_IsZero()
    {
        var ex = Assert.Throws<ArgumentException>(() => _calculator.Divider(6, 0));
        Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
    }
    
}