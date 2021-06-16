﻿using System;
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

            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(Product.counter +  "개 생성되었습니다.");

            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            //Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            //Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");
        }

        class Sample
        {
            public static int value;
            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }

        class Product
        {
            public static int counter = 0;
            public readonly int id;     // 생성자에서만 딱 1번 변경 가능.
            public string name;
            public int price;

            /*우클릭 -> 빠른작업 및 리펙터링 -> 생성자*/
            public Product(string name, int price)
            {
                Product.counter = Product.counter + 1;
                this.id = Product.counter;

                //this.id = ++Product.counter;
                this.name = name;
                this.price = price;
            }

            ~Product()
            {
                Console.WriteLine(this + "의 소멸자 호출되었습니다.");
                Console.WriteLine(this.name + "曰 : \" 안녕히 계세요 여러분~\"");
            }

            /*우클릭 -> 빠른작업 및 리펙터링 -> 재정의 생성(오버로딩)*/
            public override string ToString()
            {
                return id + " : " + name;
            }

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
