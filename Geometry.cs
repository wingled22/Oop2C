using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ConsolePelayo2
{
    public class Geometry
    {

        public double Area { get; set; }
        public double Perimeter { get; set; }

        public void CalculateArea()
        {
            if (this is Circle circle)
            {
                circle.Area = Math.PI * Math.Pow(circle.Radius, 2);
            }
            else if (this is Rectangle rectangle)
            {
                rectangle.Area = rectangle.Width * rectangle.Height;
            }
            else if (this is Square square)
            {
                square.Area = Math.Pow(square.Side, 2);
            }else if (this is Triangle triangle){
                triangle.Area = (triangle.Base * triangle.Height) / 2;
            }
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine("Perimeter is " + Perimeter);
        }
    }
}