using UltimateGeometry.Utils;

namespace UltimateGeometry.Figures;

public class TriangleShape : ITriangleShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    private double? _area = null;

    private bool? _isRight = null;

    public TriangleShape(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double Area { 
        get {
            if (_area is null)
            {
                _area = AreaCalculator.CalculateTriangleArea(_sideA, _sideB, _sideC);
            }

            return (double)_area;
        } 
    }

    public bool IsRight
    {
        get
        {
            if (_isRight is null)
            {
                _isRight = AreaCalculator.IsRightTriangle(_sideA, _sideB, _sideC);
            }

            return (bool)_isRight;
        }
    }
}
