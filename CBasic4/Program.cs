﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
    class Car
    {
        int carNumber;
        DateTime inTime;        // 날짜와 시간을 가지는 자료형
        DateTime outTime;       // c#기본은 private

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class Program
    {
        // 클래스 이름 충돌!
/*        class Math
        {

        }*/
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));    // 0이상 99까지 - maximum : 미만
            Console.WriteLine(random.Next(10, 100)); // 이상 미만

            Console.WriteLine(random.NextDouble());     // 0이상 1미만
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 100);

            List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            foreach (var item in list)      //foreach 탭 두번
            {
                Console.WriteLine("Count:" + list.Count + "\titem: " + item);
            }
            list.Remove(52);
            foreach (var item in list)      //foreach 탭 두번
            {
                Console.WriteLine("Count:" + list.Count + "\titem: " + item);
                //list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

            Product product = new Product();
        }
    }

    class FirstClass
    {

    }
    class SecodnClass
    {
        class ChildClass
        {

        }
    }
}
