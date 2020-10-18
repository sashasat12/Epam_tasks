namespace FigureLIb
{
    public class SquareFigure : Figure
    {
        public SquareFigure(string name, params Point[] point) : base(name, point)
        {
        }

        public override double Perimetr()
        {
            return Point.LenthBetweenpoints(point[0], point[1]) * 4;
        }

        public override double Square()
        {
            return Point.LenthBetweenpoints(point[0], point[1]) * Point.LenthBetweenpoints(point[0], point[1]);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}