using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionBasic
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Name = "sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            double vol = Math.PI * (4 / 3) * (Math.Pow(Radius,3));
            return vol;

        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The sphere has the radius {Radius}");
        }
    }
}
