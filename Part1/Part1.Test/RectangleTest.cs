using System.Reflection;

namespace Part1.Test;

[TestFixture]
public class RectangleTest
{
    private readonly IShape rectangle = new Rectangle(4,5);

    [Test]
    public void TestRectangleCalculateArea()
    {
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(20));
    }

    [Test]
    public void TestRectangleCalculateVolume()
    {
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
    }
    
    //this test will be failed
    [TestCase(Double.NaN,Double.NaN, ExpectedResult = Double.NaN)]
    [TestCase(Double.PositiveInfinity,Double.PositiveInfinity, ExpectedResult = Double.PositiveInfinity)]
    [TestCase(Double.NegativeInfinity,Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1,-1, ExpectedResult = 0)]
    public double TestRectangleCalculateAreaWithInvalidValue(double length,double width)
    {
        IShape invalidRectangle = new Rectangle(length,width);
        return invalidRectangle.CalculateArea();
    }
    
    [TestCase(Double.NaN,Double.NaN, ExpectedResult = 0)]
    [TestCase(Double.PositiveInfinity,Double.PositiveInfinity, ExpectedResult = 0)]
    [TestCase(Double.NegativeInfinity,Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1,-1, ExpectedResult = 0)]
    public double TestRectangleCalculateVolumeWithInvalidValue(double length,double width)
    {
        IShape invalidRectangle = new Rectangle(length,width);
        return invalidRectangle.CalculateVolume();
    }

}