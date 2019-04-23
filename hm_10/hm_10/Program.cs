using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace hm_10
{
    class Program
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Namespace is hm_10");
            log.Info("A process of array initialization was started");
            

            IFigure[] arr = new IFigure[3];

            Random random = new Random();
            Square square = new Square(random.Next(1, 11));
            Circle circle = new Circle(random.Next(1, 11));

            int SideAb, longSide;
            // we cant create triangle if side a + b < long side C
            do
            {
                SideAb = random.Next(1, 11);
                longSide = random.Next(1, 11);
            }
            while (longSide > SideAb * 2);

            Triangle triangle = new Triangle(SideAb, longSide);

            arr[0] = square;
            arr[1] = circle;
            arr[2] = triangle;

            foreach (IFigure item in arr)
            {
                log.Info($"A process of {item.Name} squarre calculation was started");
                Console.WriteLine($"This is {item.Name}. CLR Type is {item.GetType()}. Square is {item.SquareCalc()}");
            }

            Console.ReadKey();
            log.Info("Program finished correctly");
        }
    }

    public interface IFigure
    {
        string Name { get; set; }
        double SquareCalc();
    }

    class Square : IFigure
    {
        public int Side { get; set; }
        public string Name { get; set; } = "Square";

        public Square(int side)
        {
            Side = side;
        }

        public double SquareCalc()
        {
            return Side * Side;
        }
    }

    class Circle : IFigure
    {
        public int Radius { get; set; }
        public string Name { get; set; } = "Circle";

        public Circle(int radius)
        {
            Radius = radius;
        }
        public double SquareCalc()
        {
            return 3.14 * Radius / 2;
        }
    }

    class Triangle : IFigure
    {
        public int SideAB { get; set; }
        public int SideC { get; set; }
        public string Name { get; set; } = "Triangle";

        public Triangle(int sideAB, int sideC)
        {
            SideAB = sideAB;
            SideC = sideC;
        }
        public double SquareCalc()
        {
            return SideC / 2 * Math.Sqrt((SideAB + SideC / 2) * (SideAB - SideC / 2));
        }
    }
}
