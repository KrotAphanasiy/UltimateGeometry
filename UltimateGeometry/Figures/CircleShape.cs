using UltimateGeometry.Utils;

namespace UltimateGeometry.Figures;

public class CircleShape : IShape
{
    private readonly double _radius;
    private double? _area;

    public CircleShape(double radius)
    {
        _radius = radius;
    }

    public double Area { 
        get
        {
            if (_area is null)
            {
                _area = AreaCalculator.CalculateCircleArea(_radius);
            }

            return (double)_area;
        }
    }
}
