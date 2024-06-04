using mindbox_task.Shapes;
using Xunit;

namespace mindbox_task.Tests;

public class ShapeTests
{
    
    [Fact]
    public void NegativeSideValueTest()
    {
        Assert.Throws<ShapeException>(() => new Triangle(-1, 2, 2));
        Assert.Throws<ShapeException>(() => new Circle(-2));
    }
    
    [Fact]
    public void SideSizeExceptionTest()
    {
        Assert.Throws<ShapeException>(() => new Triangle(1, 2, 3));
        Assert.Throws<ShapeException>(() => new Triangle(1, 2, 2));
    }
    
    [Fact]
    public void EvaluateDefaultTriangleAreaTest()
    {
        IShape triangle = new Triangle(2, 3, 4);
        var area = triangle.EvaluateArea();
        
        Assert.Equal(2.9047375096555625, area);
    }
    
    [Fact]
    public void EvaluateRightAngleAreaTest()
    {
        IShape triangle = new Triangle(3, 4, 5);
        var area = triangle.EvaluateArea();
        
        Assert.Equal(6, area);
    }
    
    [Fact]
    public void EvaluateCircleAreaTest()
    {
        IShape circle = new Circle(3);
        var area = circle.EvaluateArea();
        
        Assert.Equal(28.274333882308138, area);
    }
}