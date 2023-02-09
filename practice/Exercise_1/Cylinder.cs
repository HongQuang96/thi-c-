using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Exercise_1
{
    internal class Cylinder

    {

        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; private set; }
        public double LateralArea { get;private set; }
        public double TotalArea { get;private set; }
        public double Volume { get;private set; }

        public Cylinder()
        {

        }

        public Cylinder(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Base Area: " + BaseArea);
            Console.WriteLine("Lateral Area: " + LateralArea);
            Console.WriteLine("Total Area: " + TotalArea);
            Console.WriteLine("Volume: " + Volume);
        }
    }

  
}
