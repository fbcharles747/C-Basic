using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismBasic
{
    internal class Audi:Car
    {
        public string Model { get; set; }
        private string brand = "Audi";
        public Audi(int hp, string color, string model) : base(hp, color)
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
            Console.WriteLine($"The Audi {Model} is repaired!");
        }
    }
}
