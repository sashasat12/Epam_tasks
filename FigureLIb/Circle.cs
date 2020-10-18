using System;

namespace FigureLIb
{
    public class Circle : Figure
    {
        public Circle(string name, params Point[] point) : base(name, point)
        {
        }

        public Circle(string name, double r, Point point) : base(name, point)
        {
            R = r;
        }

        public double R { get; set; }

        public override double Perimetr()
        {
            return 2 * R * Math.PI;
        }

        public override double Square()
        {
            return Math.PI * R * R;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var points in point)
                result += $"Тип фигуры{this.GetType()}\nName {Name}\n{points.ToString()}" + $"Radius: {R} ";
            return result;
        }
    }
}