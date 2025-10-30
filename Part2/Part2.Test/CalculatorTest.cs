namespace Part2.Test;

public class Tests
{
    [TestCase(1,2,"+",ExpectedResult = 3)]
    [TestCase(1,Double.NaN,"+",ExpectedResult = Double.NaN)]
    [TestCase(1,Double.PositiveInfinity,"+",ExpectedResult = Double.PositiveInfinity)]
    [TestCase(1,Double.NegativeInfinity,"+",ExpectedResult = Double.NegativeInfinity)]
    [TestCase(0,Double.Epsilon,"+",ExpectedResult = Double.Epsilon)]
    public double CalculatorAddTestShouldExpectedValue(double a, double b,string operation)
    {
        Calculator cal=new Calculator(a,b,operation);
        return cal.Calculate();
    }
    
    [TestCase(1,2,"-",ExpectedResult = -1)]
    [TestCase(1,Double.NaN,"-",ExpectedResult = Double.NaN)]
    [TestCase(1,Double.PositiveInfinity,"-",ExpectedResult = Double.NegativeInfinity)]
    [TestCase(1,Double.NegativeInfinity,"-",ExpectedResult = Double.PositiveInfinity)]
    [TestCase(0,Double.Epsilon,"-",ExpectedResult = -Double.Epsilon)]
    public double CalculatorSubtractTestShouldExpectedValue(double a, double b,string operation)
    {
        Calculator cal=new Calculator(a,b,operation);
        return cal.Calculate();
    }
    
    [TestCase(1,2,"*",ExpectedResult = 2)]
    [TestCase(1,Double.NaN,"*",ExpectedResult = Double.NaN)]
    [TestCase(1,Double.PositiveInfinity,"*",ExpectedResult = Double.PositiveInfinity)]
    [TestCase(1,Double.NegativeInfinity,"*",ExpectedResult = Double.NegativeInfinity)]
    [TestCase(0,Double.Epsilon,"*",ExpectedResult = 0)]
    public double CalculatorMultiplyTestShouldExpectedValue(double a, double b,string operation)
    {
        Calculator cal=new Calculator(a,b,operation);
        return cal.Calculate();
    }
    
   
    [TestCase(1,2,"/",ExpectedResult = 0.5)]
    [TestCase(1,Double.NaN,"/",ExpectedResult = Double.NaN)]
    [TestCase(1,Double.PositiveInfinity,"/",ExpectedResult = 0)]
    [TestCase(1,Double.NegativeInfinity,"/",ExpectedResult = -0)]
    [TestCase(0,Double.Epsilon,"/",ExpectedResult = 0)]
    public double CalculatorDivideTestShouldExpectedValue(double a, double b,string operation)
    {
        Calculator cal=new Calculator(a,b,operation);
        return cal.Calculate();
    }
    
    [Test]
    public void CalculatorDivideByZeroShouldThrow()
    {
        Calculator cal=new Calculator(0,0,"/");
        Assert.Throws<DivideByZeroException>(() => { cal.Calculate(); });
    }

    [TestCase("%")]
    [TestCase("x")]
    [TestCase("無効な演算子です")]
    [TestCase("")]
    public void CalculatorInvalidOperationShouldThrow(string operation)
    {
        Calculator cal=new Calculator(0,0,operation);
        Assert.Throws<ArgumentException>(() => { cal.Calculate(); });
    }

    [Test]
    public void CalculatorNullOperationShouldThrow()
    {
        Calculator cal=new Calculator(0,0,null!);
        Assert.Throws<ArgumentException>(() => { cal.Calculate(); });
    }
}