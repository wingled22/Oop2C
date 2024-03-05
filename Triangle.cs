using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsolePelayo2
{
    public class Triangle : Geometry
    {
        public int Base { get; set; }
        public int Height { get; set; }
        public int Side1 { get; set; }

        public new void CalculatePerimeter(){

            Console.WriteLine("Perimeter is " + (Base + Height + Side1));
        }
    }
}