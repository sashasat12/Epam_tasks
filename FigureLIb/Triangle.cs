namespace FigureLIb
{
    public class Triangle : Figure
    {
        public Triangle(string name, params Point[] point) : base(name, point)
        {
        }

        public override double Perimetr()
        {
            return Point.LenthBetweenpoints(point[0], point[1]) + Point.LenthBetweenpoints(point[1], point[2]) + Point.LenthBetweenpoints(point[0], point[2]);
        }

        public override double Square()
        {
            return (Point.Dy(point[0], point[1]) * Point.Dx(point[0], point[2])) / 2;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}