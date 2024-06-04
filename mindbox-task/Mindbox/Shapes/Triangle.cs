namespace mindbox_task.Shapes;

public class Triangle : IShape
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw ShapeException.NegativeValueException();
        }

        if (!(firstSide + secondSide > thirdSide
              && secondSide + thirdSide > firstSide
              && thirdSide + firstSide > secondSide))
        {
            throw ShapeException.SideSizeException();
        }
        
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }
    
    public double EvaluateArea()
    {
        if (Math.Abs(Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) - Math.Pow(_thirdSide, 2)) < 0.000001)
        {
            return _firstSide * _secondSide * 0.5;
        }

        if (Math.Abs(Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) - Math.Pow(_secondSide, 2)) < 0.000001)
        {
            return _firstSide * _thirdSide * 0.5;
        }
        
        if (Math.Abs(Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2) - Math.Pow(_firstSide, 2)) < 0.000001)
        {
            return _secondSide * _thirdSide * 0.5;
        }

        var p = (_firstSide + _secondSide + _thirdSide) / 2;
        var area = Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
        return area;
    }
}