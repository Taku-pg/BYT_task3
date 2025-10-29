using System.Reflection;

namespace Part1.Test;

[TestFixture]
public class CubeTest
{
    private readonly IShape cube = new Cube(4);

    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(cube.CalculateArea(), Is.EqualTo(96.000).Within(0.001));
        
    }

    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(cube.CalculateVolume(), Is.EqualTo(64.000).Within(0.001));
    }
    
    //these tests will be failed
    [TestCase(Double.NaN, ExpectedResult = Double.NaN)]
    [TestCase(Double.PositiveInfinity, ExpectedResult = Double.PositiveInfinity)]
    [TestCase(Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1, ExpectedResult = 0)]
    public double TestCubeCalculateAreaWithInvalidSide(double side)
    {
        IShape invalidCube = new Cube(side);
        return invalidCube.CalculateArea();
    }
    
    [TestCase(Double.NaN, ExpectedResult = Double.NaN)]
    [TestCase(Double.PositiveInfinity, ExpectedResult = Double.PositiveInfinity)]
    [TestCase(Double.NegativeInfinity, ExpectedResult = 0)]
    [TestCase(-1, ExpectedResult = 0)]
    public double TestCubeCalculateVolumeWithInvalidSide(double side)
    {
        IShape invalidCube = new Cube(side);
        return invalidCube.CalculateVolume();
    }
}