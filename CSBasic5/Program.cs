using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiClass m1 = new MultiClass();
            Console.WriteLine(m1.Multi(52, 273));
            Console.WriteLine(m1.Multi(103, 32));
            m1.Print();
            /*Console.WriteLine(m1.Sum(1, 100));
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(273));
            Console.WriteLine(MyMath.Abs(52.273f));
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(30000000000));*/

            Console.WriteLine(m1.Sum(1, 100));
            MyMath.Abs(52);
            MyMath.Abs(273);
            MyMath.Abs(52.273f);
            MyMath.Abs(52.273);
            MyMath.Abs(30000000000);

            m1.somePublic();
            //m1.someDefault();
            //m1.somePrivate();
        }

        class MyMath
        {
            public static void Abs(int input)
            {
                Console.WriteLine("정수:" + ((input < 0) ? -input : input));
            }
            public static void Abs(double input)
            {
                Console.WriteLine("더블:" + ((input < 0) ? -input : input));
            }
            public static void Abs(long input)
            {
                Console.WriteLine("롱:" + ((input < 0) ? -input : input));
            }

            /*public static int Abs(int input)
            {
                return (input < 0) ? -input : input;
                *//*
                 if(input < 0)
                    {
                    return -input;
                }
                else
                {
                    return input;
                }
                *//*
            }
            public static double Abs(double input)
            {
                return (input < 0) ? -input : input;
            }
            public static long Abs(long input)
            {
                return (input < 0) ? -input : input;
            }*/
        }

        class MultiClass
        {
            public void somePublic()
            {
                Console.WriteLine("public!");
            }
            void someDefault()
            {
                Console.WriteLine("Default");
            }
            private void somePrivate()
            {
                Console.WriteLine("private!");
            }

            public int Multi (int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출!");
            }

            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
    }
}
