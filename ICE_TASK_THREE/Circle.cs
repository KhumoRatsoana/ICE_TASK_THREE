using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_THREE
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        public Circle(double radius) : base ("Circle")
        {
            this.Radius = radius;
        }

        public void CalculateArea()
        {
            double area = ((Radius * Radius) * Math.PI);
            Console.WriteLine($"Area: {area}");
            //radius squared Math.pie

        }
    }
}
