namespace mindbox_task.Shapes;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw ShapeException.NegativeValueException();
        }
        
        _radius = radius;
    }

    public double EvaluateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}