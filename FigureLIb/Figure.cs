namespace FigureLIb
{
    public abstract class Figure
    {
        public Point[] point { get; set; }
        public string Name { get; private set; }

        public override string ToString()
        {
            string result = $"Тип фигуры {this.GetType()}\nName {Name}\n";
            foreach (var point in point)
                result += point.ToString();
            return result;
        }

        public Figure(string name, params Point[] point)
        {
            Name = name;
            this.point = point;
        }

        public abstract double Square();

        public abstract double Perimetr();
    }
}