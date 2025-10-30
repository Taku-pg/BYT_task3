using System.Reflection;

namespace Part1.Test;

[TestFixture]
public class CylinderTest
{
    private readonly IShape cylinder = new Cylinder(3, 7);

    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
    }
    
    
    //this test will be failed
    [TestCase(Double.NaN,Double.NaN, ExpectedResult = Double.NaN)]
    [TestCase(Double.PositiveInfinity,Double.PositiveInfinity, ExpectedResult = Double.PositiveInfinity)]
    [TestCase(Double.NegativeInfinity,Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1,-1, ExpectedResult = 0)]
    public double TestRectangleCalculateAreaWithInvalidValue(double radius,double height)
    {
        IShape invalidCylinder = new Cylinder(radius,height);
        return invalidCylinder.CalculateArea();
    }
    
    [TestCase(Double.NaN,Double.NaN, ExpectedResult = Double.NaN)]
    [TestCase(Double.PositiveInfinity,Double.PositiveInfinity, ExpectedResult = Double.PositiveInfinity)]
    [TestCase(Double.NegativeInfinity,Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1,-1, ExpectedResult = 0)]
    public double TestRectangleCalculateVolumeWithInvalidValue(double radius,double height)
    {
        IShape invalidCylinder = new Cylinder(radius, height);
        return invalidCylinder.CalculateVolume();
    }
}