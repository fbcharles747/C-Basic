using System;
using System.Collections.Generic;

namespace PolymorphismBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car> 
            { 
                new Audi(200,"black","A4"),
                new BMW(250,"white","M4")
            };
            foreach (var car in cars)
            {
                car.ShowDetail();
            }

            Car bmwZ3 = new BMW(250, "brown", "Z3");
            bmwZ3.SetCarIDInfo(1234, "Charles Huang");
            bmwZ3.GetCarIDInfo();
        }
    }
}
