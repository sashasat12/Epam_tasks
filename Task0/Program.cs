using FigureLIb;
using System;

namespace Task0
{
    internal class Program
    {
        private static int GetInt(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
            return 0;
        }

        private static double GetDouble(string str)
        {
            try
            {
                return double.Parse(str);
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
            return 0;
        }

        private static Point[] GetPoints(int count)
        {
            Point[] points = new Point[count];
            for (int i = 0; i < points.Length; i++)
                points[i] = GetPoint();
            return points;
        }

        private static Point GetPoint()
        {
            Console.WriteLine("Введите координаты точки");
            return new Point(GetInt(Console.ReadLine()), GetInt(Console.ReadLine()));
        }

        private static void Menu()
        {
            Console.WriteLine("\n1.Введите новое кол-во фигур(обнуление всех веденых фигур)");
            Console.WriteLine("2.Ввести окружность");
            Console.WriteLine("3.Ввести элипс");
            Console.WriteLine("4.Ввести прямоугольник");
            Console.WriteLine("5.Ввести квадрат");
            Console.WriteLine("6.Ввести треугольник");
            Console.WriteLine("7.Средний периметр и площадь всех фигур");
            Console.WriteLine("8.Фигуру наибольшей площади");
            Console.WriteLine("9.Тип фигуры с наибольши значением среднего периметра среди всех других фигур");
            Console.WriteLine("10.Вывод всех фигур ");
        }

        private static void Main(string[] args)
        {
            int figurCount;
            int createFigur = 0;
            int choice = 0;
            Console.WriteLine("Введите кол-во фигур");
            figurCount = GetInt(Console.ReadLine());
            Figure[] mass = new Figure[figurCount];
            while (choice != 11)
            {
                Console.Clear();
                Console.WriteLine($"Кол-во возможных фигур - {figurCount}\nКол-во введенных фигур - {createFigur}");
                Menu();
                choice = GetInt(Console.ReadLine());
                if (figurCount == createFigur)
                {
                    if (choice >= 7 && choice <= 10 || choice == 1)
                    {
                    }
                    else
                    {
                        Console.WriteLine("Создать больше фигур нельзя\nОбнулите фигуры");
                        choice = 1;
                    }
                }
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\n Введите кол-во фигур");
                            figurCount = GetInt(Console.ReadLine());
                            mass = new Figure[figurCount];
                            createFigur = 0;
                        }; break;
                    case 2:
                        {
                            Console.WriteLine("Ввод окружности\nВведите имя окружности, радиус и координаты");
                            mass[createFigur] = new Circle(Console.ReadLine(), GetDouble(Console.ReadLine()), GetPoint());
                            createFigur++;
                        }; break;
                    case 3:
                        {
                            Console.WriteLine("Ввод элипса\nВведите имя окружности,2 радиуса и координаты");
                            mass[createFigur] = new Ellipse(Console.ReadLine(), GetDouble(Console.ReadLine()), GetDouble(Console.ReadLine()), GetPoint());
                            createFigur++;
                        }; break;
                    case 4:
                        {
                            Console.WriteLine("Введите прямоугольник и 4 координаты");
                            mass[createFigur] = new Rectangle(Console.ReadLine(), GetPoints(4));
                            createFigur++;
                        }; break;
                    case 5:
                        {
                            Console.WriteLine("Введите квадрат и 4 координаты");
                            mass[createFigur] = new SquareFigure(Console.ReadLine(), GetPoints(4));
                            createFigur++;
                        }; break;
                    case 6:
                        {
                            Console.WriteLine("Введите треугольник и 3 координаты");
                            mass[createFigur] = new Triangle(Console.ReadLine(), GetPoints(3));
                            createFigur++;
                        }; break;
                    case 7:
                        {
                            double sumPerimatr = 0;
                            double sumSquare = 0;
                            for (int i = 0; i < createFigur; i++)
                            {
                                sumPerimatr += mass[i].Perimetr();
                                sumSquare += mass[i].Square();
                            }

                            Console.WriteLine($"Средний периметр всех фигур = {sumPerimatr / createFigur} \nСредняя площадь всех фигур = {sumSquare / createFigur} ");
                            Console.ReadLine();
                        }; break;
                    case 8:
                        {
                            if (createFigur != 0)
                            {
                                double square = mass[0].Square();
                                Figure bigSquareFigure = mass[0];

                                for (int i = 0; i < createFigur; i++)
                                {
                                    if (mass[i].Square() > square)
                                    {
                                        square = mass[i].Square();
                                        bigSquareFigure = mass[i];
                                    }
                                }

                                Console.WriteLine($"{bigSquareFigure.ToString()} Фигуру наибольшей площади равна {square} ");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"Нет ни одной созданной фигуры ");
                                Console.ReadLine();
                            }
                        }; break;
                    case 9:
                        {
                            if (createFigur != 0)
                            {
                                double perimetr = mass[0].Perimetr();
                                Figure bigPerimetrFigure = mass[0];

                                for (int i = 0; i < createFigur; i++)
                                {
                                    if (mass[i].Perimetr() > perimetr)
                                    {
                                        perimetr = mass[i].Perimetr();
                                        bigPerimetrFigure = mass[i];
                                    }
                                }
                                Console.WriteLine($"{bigPerimetrFigure.ToString()}\n-тип фигуры с наибольши значением среднего периметра среди всех других фигур {perimetr} ");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"Нет ни одной созданной фигуры ");
                                Console.ReadLine();
                            }
                        }; break;
                    case 10:
                        {
                            for (int i = 0; i < createFigur; i++)
                            {
                                Console.WriteLine(mass[i].ToString());
                                Console.ReadLine();
                            }
                        }; break;
                    default: Console.WriteLine("Вы ввели некорректное число"); continue;
                }
            }

            Console.ReadLine();
        }
    }
}