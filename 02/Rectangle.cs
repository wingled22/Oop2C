using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsolePelayo2
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public new void CalculateArea()
        {
            Console.WriteLine("Area = " + (Width * Height)); 
        }

        // public override void CalculatePerimeter()
        // {
        //     Console.WriteLine("calculatePerimeter from Retangle");
        // }


    }
}