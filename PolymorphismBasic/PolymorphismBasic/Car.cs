using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismBasic
{
    internal class Car
    {
        protected CarIDInfo carInfo=new CarIDInfo();
        public void SetCarIDInfo(int id,string owner)
        {
            carInfo.Owner = owner;
            carInfo.IDnum=id;
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine($"Car ID: {carInfo.IDnum}. {carInfo.Owner} own the car.");
        }
        public int HP { get; set; }
        public string Color { get; set; }
        public Car(int hp,string color)
        {
            HP = hp;
            Color = color;
        }
        public virtual void ShowDetail()
        {
            Console.WriteLine($"The car has {this.HP} horse power. Color: {this.Color}");
        }
        public virtual void Repair()
        {
            Console.WriteLine("The car is repaired!");
        }
    }
        
}
