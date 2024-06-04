namespace mindbox_task.Shapes;

public class ShapeException : Exception
{
    public ShapeException(string? message) : base(message) { }

    public static ShapeException NegativeValueException()
    {
        return new ShapeException("Value cannot be negative");
    }

    public static ShapeException SideSizeException()
    {
        return new ShapeException("the values don't satisfy the dimensions of the sides of the triangle");
    }
}