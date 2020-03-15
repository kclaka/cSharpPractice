using System;

namespace tutorial101
{

    public struct point
    {
        public int x;
        public int y;
    } 

    public class Panda
    {
        public string name;
        public static int Population;

        public Panda(string Name)
        {
            name = Name;
            Population = Population + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            point p3 = new point();
            p3.x = 10;
            p3.y = 24;

            Panda P1 = new Panda("Pan Deh");
            Panda P2 = new Panda("Pan Dah");

            Console.WriteLine(P1.name);
            Console.WriteLine(P2.name);
            Console.WriteLine(Panda.Population);

            Mtest();
            Console.WriteLine(FeetToInches(23));
            Console.WriteLine("Hello World!");
        }

        static void Mtest()
        {
            int x = 12 * 30;
            Console.WriteLine(x);

            string message = "Corona Virus";
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);

            int x1 = 2020;
            string m1 = message + " " + x1.ToString();
            Console.WriteLine(m1);

            bool simpleVar = true;
            if (simpleVar)
            {
                Console.WriteLine("Print Me");
            }
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
