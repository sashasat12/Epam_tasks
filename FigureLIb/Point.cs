using System;

namespace FigureLIb
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Точка ({X},{Y})\n";
        }

        public static double LenthBetweenpoints(Point p1, Point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }

        public static double Dy(Point p1, Point p2)
        {
            return p2.Y - p1.Y;
        }

        public static double Dx(Point p1, Point p2)
        {
            return p2.X - p1.X;
        }
    }
}