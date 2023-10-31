using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(16));
        }
        // Power
        static int Pow(int num)
        {
            return num * num;
        }
        // Area
        static int Area(int Radius)
        {
            int Pi = 3;
            return Pi * Pow(Radius);
        }
        static int Area(int A, int B)
        {
            return A * B;
        }
        static double Area(int A, int B,int C ,int Radius)
        {
            double Perimetr = (A + B + C)/2;
            return Perimetr*Radius;
        }
        // SumFunction
        static int Sum(int x)
        {
            int result1=0,result2=0;

            for (int i = 1; result1 < x; i++)
            {
                result1 += i;
                result2 = result1 - i;
            }
            if(result1 - x < x- result2)
            {
                return result1;
            }
            return result2;
        }

    }

}
