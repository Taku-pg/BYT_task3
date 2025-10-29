using System.Reflection;

namespace Part1.Test;

public class SphereTest
{
    private readonly IShape sphere = new Sphere(5);

    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }
    
    //these tests will be failed
    [TestCase(Double.NaN, ExpectedResult = Double.NaN)]
    [TestCase(Double.PositiveInfinity, ExpectedResult = Double.PositiveInfinity)]
    [TestCase(Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1, ExpectedResult = 0)]
    public double TestSphereCalculateAreaWithInvalidRadius(double radius)
    {
        IShape invalidSphere = new Sphere(radius);
        return invalidSphere.CalculateArea();
    }
    
    [TestCase(Double.NaN, ExpectedResult = Double.NaN)]
    [TestCase(Double.PositiveInfinity, ExpectedResult = Double.PositiveInfinity)]
    [TestCase(Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1, ExpectedResult = 0)]
    public double TestSphereCalculateVolumeWithInvalidRadius(double radius)
    {
        IShape invalidSphere = new Sphere(radius);
        return invalidSphere.CalculateVolume();
    }
    
    
}