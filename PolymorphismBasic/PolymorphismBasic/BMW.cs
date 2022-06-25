using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismBasic
{
    internal class BMW:Car
    {
        public string Model { get; set; }
        private string brand = "BMW";
        public BMW(int hp, string color, string model):base(hp,color)
        {
            Model = model;
        }
        public override void ShowDetail()
        {
            Console.WriteLine($"Brand: {brand} Model: {Model}");
            base.ShowDetail();
        }
        public override void Repair()
        {
            Console.WriteLine($"The BMW {Model} has been repaired!");
        }
    }
}
