using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public partial class Auto {
            private double max_speed;
            private double engine_capacity;
            private double boost0to100;
            private double boost0to200;
            private double quoter_mile;
            public double MaxSpeed
            {
                get => max_speed;
                set => max_speed = value;
            }
            public double EngineCapacity
            {
                get { return engine_capacity; }
                set { engine_capacity = value; }
            }
            public double Boost0to100
            {
                get => boost0to100;
                set { boost0to100 = value; }
            }
            private double Boost0to200
            {
                get { return boost0to200; }
                set { boost0to200 = value; }
            }
            private double QuoterMile
            {
                get => quoter_mile;
                set { quoter_mile = value; }
            }
            public Auto()
            {
                max_speed = 0;
                engine_capacity = 0;
                boost0to100 = 0;
                quoter_mile = 0;
                boost0to200 = 0;
            }
            public Auto(double max_speed, double engine_capacity, double boost0to100)
            {
                this.max_speed = max_speed;
                this.engine_capacity = engine_capacity;
                this.boost0to100 = boost0to100;
                this.boost0to200 = boost0to100 * 3;
                this.quoter_mile = 0.402*3600 / (max_speed);

            }
            public void clear()
            {
                max_speed = 0;
                engine_capacity = 0;
                boost0to100 = 0;
                quoter_mile = 0;
                boost0to200 = 0;
            }
            public void swap_engine(double N_Engine_Capacity)
            {
                this.quoter_mile *= (EngineCapacity / N_Engine_Capacity);
                this.engine_capacity = N_Engine_Capacity;
            }
            public void race()
            {
                Console.WriteLine($"You raced and won quoter mile with time {quoter_mile}");
            }
        }
        public partial class Auto
        {
            public void show()
            {
                Console.WriteLine($"Max speed: {this.max_speed};");
                Console.WriteLine($"Engine capacity: {this.engine_capacity};");
                Console.WriteLine($"Quoter mile: {this.quoter_mile};");
            }
        }
        static void Main(string[] args)
        {
            Auto[] Auto_arr = new Auto[5];
            Auto Dodge = new Auto(200, 6.2, 3);
            Dodge.show();
            Console.WriteLine("Engine swapped to 8 Liters!");
            Dodge.swap_engine(8.0);
            Dodge.race();
        }
    }
}