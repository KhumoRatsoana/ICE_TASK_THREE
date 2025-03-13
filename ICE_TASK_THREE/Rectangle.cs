using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_THREE
{
     class Rectangle : Shape, ICalculateArea
    {
        public double Width { get; set; }

        public double Length { get; set; }

        public Rectangle (double width, double length) : base ("rectangle")
        {

            Width = width;
            Length = length;
        }

        public void CalculateArea() {

            double area = Width * Length;
            Console.WriteLine($"Area: {area}");
        
        }


    }
}
