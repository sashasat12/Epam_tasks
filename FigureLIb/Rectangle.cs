namespace FigureLIb
{
    public class Rectangle : Figure
    {
        public Rectangle(string name, params Point[] point) : base(name, point)
        {
        }

        public override double Perimetr()
        {
            return (Point.LenthBetweenpoints(point[0], point[1]) + Point.LenthBetweenpoints(point[0], point[3])) * 2;
        }

        public override double Square()
        {
            return (Point.LenthBetweenpoints(point[0], point[1]) * Point.LenthBetweenpoints(point[0], point[3]));
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}