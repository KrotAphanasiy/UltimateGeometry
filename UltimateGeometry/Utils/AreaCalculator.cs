namespace UltimateGeometry.Utils;

public static class AreaCalculator
{
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
    {
        double areaInSquare = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(areaInSquare * (areaInSquare - sideA) * (areaInSquare - sideB) * (areaInSquare - sideC));
    }

    public static bool IsRightTriangle(double sideA, double sideB, double sideC)
    {
        double[] sides = { sideA, sideB, sideC };
        Array.Sort(sides);
        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }
}
