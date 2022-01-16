using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct Auto
        {
            string Name;
            double Length;
            double Width;
            double Clearance;
            double EngineCapacity;
            double EnginePower;
            string Color;
            string Gearbox;

            public Auto(string name, double length, double width, double clearance, double engineCapacity, double enginePower, string color, string gearbox)
            {
                Name = name;
                Length = length;
                Width = width;
                Clearance = clearance;
                EngineCapacity = engineCapacity;
                EnginePower = enginePower;
                Color = color;
                Gearbox = gearbox;
            }

            public void Show()
            {
                Console.Write($"Name: {Name}; Color: {Color};\n" +
                    $"Length: {Length}; Width: {Width}; Clearance: {Clearance}\n" +
                    $"Engine Capacity: {EngineCapacity}; Engine power: {EnginePower};\n" +
                    $"Gearbox: {Gearbox}");
            }
        }
        public struct Complex
        {
            public double r, i;
            public Complex Sum(Complex a, Complex b)
            {
                Complex res = new Complex();
                res.r = a.r + b.r;
                res.i = a.i + b.i;
                return res;
            }

            public Complex Multiplication(Complex a, Complex b)
            {
                Complex res = new Complex();
                res.r = a.r * b.r;
                res.i = a.i * b.i;
                return res;
            }

            public Complex Subtract(Complex a, Complex b)
            {
                Complex res = new Complex();
                res.r = a.r - b.r;
                res.i = a.i - b.i;
                return res;
            }
            public Complex Division(Complex a, Complex b)
            {
                Complex res = new Complex();
                res.r = a.r / b.r;
                res.i = a.i / b.i;
                return res;
            }

            public void Print(Complex a)
            {
                Console.Write("{0} + i{1}", a.r, a.i);
            }

            public void PrintLine(Complex a)
            {
                Console.WriteLine("{0} + i{1}", a.r, a.i);
            }
        }
        static void Main(string[] args)
        {
            //Auto astra = new Auto("Opel Astra", 4249, 1753, 160, 1.6, 105, "black", "Manual") ;
            //astra.Show();
            Console.Write("Введите целую часть первого комплексного числа: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i2 = Convert.ToDouble(Console.ReadLine());
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.r = r1;
            c1.i = i1;
            c2.r = r2;
            c2.i = i2;
            Console.WriteLine("Введенные комплексные числа: ");
            c1.PrintLine(c1);
            c2.PrintLine(c2);
            Console.WriteLine("Сложение комплексных чисел:       {0} + {1}i", c1.Sum(c1, c2).r, c1.Sum(c1, c2).i);
            Console.WriteLine("Умножение комплексных чисел:      {0} + {1}i", c1.Multiplication(c1, c2).r, c1.Multiplication(c1, c2).i);
            Console.WriteLine("Вычитание комплексных чисел:      {0} + {1}i", c1.Subtract(c1, c2).r, c1.Subtract(c1, c2).i);
            Console.WriteLine("Деление комплексных чисел:      {0} + {1}i", c1.Division(c1, c2).r, c1.Division(c1, c2).i);
        }
    }
}