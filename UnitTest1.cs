using Review_Week5;

public class Tests
{
    private TestCalculator calc;
    [SetUp]
    public void Setup()
    {
        calc = new TestCalculator();
    }

    [Test]
    public void Add()
    {
        int a = 10;
        int b = 5;
        int sum = 15;

        var result = calc.Add(a, b);

        Assert.AreEqual(sum, result);
    }
    [Test]

    public void Subtract()
    {
        int a = 10;
        int b = 5;
        int sub = 5;

        var result = calc.Subtract(a, b);

        Assert.AreEqual(sub, result);
    }

    [Test]

    public void Multiply()
    {
        int a = 10;
        int b = 5;
        int mult = 50;

        var result = calc.Multiply(a, b);

        Assert.AreEqual(mult, result);
    }

    [Test]
    public void MultiplyByZero()
    {
        int a = 10;
        int b = 0;
        int mult = 0;
        var result = calc.Multiply(a, b);
        Assert.AreEqual(mult, result);
    }

    [Test]
    public void MultiplyByNegative()
    {
        int a = 10;
        int b = -5;
        int mult = -50;
        var result = calc.Multiply(a, b);
        Assert.AreEqual(mult, result);
    }

    [Test]
    public void MultiplyNegativeByPositive()
    {
        int a = -10;
        int b = 5;
        int mult = -50;
        var result = calc.Multiply(a, b);
        Assert.AreEqual(mult, result);
    }

    [Test]
    public void MultiplyNegativeByNegative()
    {
        int a = -10;
        int b = -5;
        int mult = 50;
        var result = calc.Multiply(a, b);
        Assert.AreEqual(mult, result);
    }

    [Test]

    public void Divide()
    {
        int a = 10;
        int b = 5;
        int div = 2;

        var result = calc.Divide(a, b);

        Assert.AreEqual(div, result);
    }

    [Test]
    public void DivideByZero()
    {
        int a = 10;
        int b = 0;
        Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));
    }

    [Test]
    public void DivideByNegative()
    {
        int a = 10;
        int b = -5;
        double div = -2;
        var result = calc.Divide(a, b);
        Assert.AreEqual(div, result);
    }

    [Test]
    public void DivideNegativeByPositive()
    {
        int a = -10;
        int b = 5;
        double div = -2;
        var result = calc.Divide(a, b);
        Assert.AreEqual(div, result);
    }

    [Test]
    public void DivideNegativeByNegative()
    {
        int a = -10;
        int b = -5;
        double div = 2;
        var result = calc.Divide(a, b);
        Assert.AreEqual(div, result);
    }
}