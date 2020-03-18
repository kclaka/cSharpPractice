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
            ArrayTest();
            Console.WriteLine(Factorial(5));
            Console.WriteLine(FeetToInches(23));
            Console.WriteLine("Hello World!");
            Console.WriteLine(default(decimal));
            int p1 = 10;
            Foo(p1);
            Console.WriteLine(p1);
            
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

            string name = "Kenny";
            Console.WriteLine($"My name is {name}");
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }

        static void ArrayTest()
        {
            char[] vowels = new char[5];
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            //Console.WriteLine(vowels[1]);

            for(int i = 0; i < vowels.Length; i++)
            {
                Console.Out.Write(vowels[i] + ",");
            }

            int[,] matrix = new int[3, 3];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                }
            }

            for(int k = 0; k < matrix.GetLength(0); k++)
            {
               for(int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.WriteLine(matrix[k, l]);
                }
            }

            
            
        }

        static int Factorial(int x)
        {
            if (x == 0)
                return 1;

            return x * Factorial(x - 1);
        }

        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }
    }


}
