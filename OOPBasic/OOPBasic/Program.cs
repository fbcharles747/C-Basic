using System;

namespace OOPBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Human denis = new Human("Denis", "Huang","brown",20);
            denis.IntroduceSelf();
            Human michael = new Human("Michael", "Huang","black",17);
            michael.IntroduceSelf();
            Human Sissy = new Human("Sissy", "Wagner","blue",59);
            Sissy.IntroduceSelf();
            */
            /*
            Box box = new Box(3, 4, 5);
            Console.WriteLine($"this box has volume{box.Volume}, front surface: {box.FrontSurface}");
            */
            Members member=new Members();
            member.Introducing(true);
            Console.Read();
        }
    }
}
