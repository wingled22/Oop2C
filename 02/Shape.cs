using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ConsolePelayo2
{
    public class Shape
    {

        public double Area { get; set; }
        public double Perimeter { get; set; }

        public void CalculateArea()
        {
            if(this is Circle circle)
                Area = Math.PI * Math.Pow(circle.Radius,2);
            else if(this is Rectangle r)
                Area = r.Height * r.Width;
            else if(this is Square s)
                Area = s.Side * s.Side;
        }
        public virtual void CalculatePerimeter()
        {
        }
    }
}