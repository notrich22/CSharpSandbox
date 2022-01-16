using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        abstract public class Figure
        {
            public double Perimeter { get; set; }
            public double Area { get; set; }

            public abstract double get_area();
            public abstract double get_perimeter();
        }
        public class Square : Figure
        {
            public double Side { get; set; }
            public override double get_area()
            {
                return Side * Side;
            }
            public override double get_perimeter()
            {
                return Side * 4;
            }
            public Square(double side)
            {
                this.Side = side;
            }
        }
        public class Triangle : Figure
        {
            double sideA, sideB, sideC;
            public override double get_area()
            {
                double P = 0.5 * (sideA + sideB + sideC);
                this.Area = Math.Sqrt(P * (P - sideA) * (P - sideB) * (P - sideC));
                return Area;
            }
            public override double get_perimeter()
            {
                this.Perimeter = sideA + sideB + sideC;
                return Perimeter;
            }
            public Triangle(double sideA, double sideB, double sideC)
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
        }
        public class Romb : Figure
            {
                public double Height { get; set; }
                public double Diagonal1 { get; set; }
                public double Diagonal2 { get; set; }
                public override double get_area()
                {
                    return Area = 0.5 * (Diagonal1 * Diagonal2);
                }
                public override double get_perimeter()
                {
                    return Perimeter = 4 * Height;
                }
                public Romb(double height)
                {
                    this.Height = height;
                }

                public Romb(double diagonal1, double diagonal2)
                {
                    this.Diagonal1 = diagonal1;
                    this.Diagonal2 = diagonal2;
                }

                public Romb(double diagonal1, double diagonal2, double height)
                {
                    this.Diagonal1 = diagonal1;
                    this.Diagonal2 = diagonal2;
                    this.Height = height;
                }
            }
        public class Rectangle : Figure
            {
                public double SideA { get; set; }
                public double SideB { get; set; }

                public Rectangle(double sideA, double sideB)
                {
                    SideA = sideA;
                    SideB = sideB;
                }
                public override double get_area()
                {
                    return Area = SideA * SideB;
                }

                public override double get_perimeter()
                {
                    return Perimeter = 2 * (SideA + SideB);
                }

            }
        public class Parallelogram : Figure
            {
                public double SideA { get; set; }
                public double SideB { get; set; }
                public double Height { get; set; }
                public Parallelogram(double sideA, double height) { 
                    SideA = sideA;
                    Height = height;
                }
                public Parallelogram(double sideA, double height, double sideB)
                {
                    SideA = sideA;
                    SideB = sideB;
                    Height = height;
                }
                public override double get_area()
                {
                    return Area = SideA * Height;
                }
                public override double get_perimeter()
                {
                    return Perimeter = 2 * (SideA + SideB);
                }
            }
        public class Trapezoid : Figure
            {
                public double Height { get; set; }
                public double SideA { get; set; }
                public double SideB { get; set; }
                public double SideC { get; set; }
                public double SideD { get; set; }


                public Trapezoid(double sideA, double sideB, double sideC, double sideD)
                {
                    SideA = sideA;
                    SideB = sideB;
                    SideC = sideC;
                    SideD = sideD;
                }
                public Trapezoid(double sideA, double sideB, double height)
                {
                    SideA = sideA;
                    SideB = sideB;
                    Height = height;
                }
                public Trapezoid(double sideA, double sideB, double sideC, double sideD, double height)
                {
                    SideA = sideA;
                    SideB = sideB;
                    SideC = sideC;
                    SideD = sideD;
                    Height = height;
                }

                public override double get_area()
                {
                    return Area = 0.5 * (SideA + SideB) * Height;

                }

                public override double get_perimeter()
                {
                    return Perimeter = SideA + SideB + SideC + SideD;
                }
            }
        public class Circle : Figure
            {
                public double Radius { get; set; }

                public Circle(double radius)
                {
                    Radius = radius;
                }

                public override double get_area()
                {

                    return Area = Math.PI * Radius * Radius;

                }

                public override double get_perimeter()
                {

                    return Perimeter = 2 * Math.PI * Radius;

                }
            }
        public class Ellipse : Figure
            {
                public double Radius { get; set; }
                public double radius { get; set; }
                public Ellipse(double Radius, double radius)
                {
                    this.Radius = Radius;
                    this.radius = radius;
                }

                public override double get_area()
                {
                    return this.Area = Math.PI * Radius * radius;
                }

                public override double get_perimeter()
                {
                    return this.Perimeter = 2 * Math.PI * Math.Sqrt(((radius*radius)+(Radius*Radius))/2);

                }
            }
        public class Mixed_Figure
        {
            List<Figure> components = new List<Figure>();
            public double Area { get; set; }
            public Mixed_Figure(Figure Main_Figure) { components.Add(Main_Figure); }
            public void add_figure(Figure figure)
            {
                components.Add(figure);
            }
            public double get_area()
            {
                foreach(Figure figure in components)
                {
                    Area += figure.get_area();
                }
                return Area;
            }
        }
        static void Main(string[] args)
            {
                Figure triangle = new Triangle(3, 4, 5);
                Console.WriteLine($"Triangle: P: {triangle.get_perimeter()}; A: {triangle.get_area()} ");
                Figure sq = new Square(3);
                Console.WriteLine($"Square: P: {sq.get_perimeter()}; A: {sq.get_area()} ");
                Figure rb = new Romb(2, 2, 2);
                Console.WriteLine($"Romb: P: {rb.get_perimeter()}; A: {rb.get_area()} ");
                Figure Rect = new Rectangle(3, 5);
                Console.WriteLine($"Rectangle: P: {Rect.get_perimeter()}; A: {Rect.get_area()} ");
                Figure prg = new Parallelogram(2, 3);
                Console.WriteLine($"Parallelogram: P: {prg.get_perimeter()}; A: {prg.get_area()} ");
                Figure trap = new Trapezoid(5, 10, 7);
                Console.WriteLine($"Trapezoid: P: {trap.get_perimeter()}; A: {trap.get_area()}");
                Figure circle = new Circle(5);
                Console.WriteLine($"Circle: P: {circle.get_perimeter()}; A: {circle.get_area()}");
                Figure ellipse = new Ellipse(3, 6);
                Console.WriteLine($"Ellipse: P: {ellipse.get_perimeter()}; A: {ellipse.get_area()}");
                Mixed_Figure MXD_FGR = new Mixed_Figure(Rect);
                MXD_FGR.add_figure(circle);
                MXD_FGR.add_figure(ellipse);
                Console.WriteLine($"Mixed figure: A: {MXD_FGR.get_area()}");
        }
    }
    }