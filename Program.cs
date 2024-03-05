using System;

namespace ConsolePelayo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Height = 10;
            r.Width = 15;
            r.CalculateArea();
            Console.WriteLine("Area of Rectangle is : " + r.Area );


            Circle c = new Circle();
            c.Radius = 10;
            c.CalculateArea();
            Console.WriteLine("Area of Circle is : " + c.Area );
        }
    }

}

