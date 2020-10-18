using System;

namespace FigureLIb
{
    public class Ellipse : Figure
    {
        public double R1 { get; private set; }
        public double R2 { get; private set; }

        public Ellipse(string name, params Point[] point) : base(name, point)
        {
        }

        public Ellipse(string name, double r1, double r2, params Point[] point) : base(name, point)
        {
            R2 = r2;
            R1 = r1;
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * Math.Sqrt((R1 * R1 + R2 * R2) / 2);
        }

        public override double Square()
        {
            return Math.PI * R2 * R1;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var points in point)
                result += $"Тип фигуры{this.GetType()} \nName {Name}\n{points.ToString()}" + $"Radius_1: {R1}\nRadius_2: {R2} ";
            return result;
        }
    }
}