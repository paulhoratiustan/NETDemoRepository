using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoProject
{
    class Program
    {
        private static Operation _add;

        delegate int Operation(int x, int y);

        //add 2 numbers
        public static int Add(int x, int y)
        {

            return x + y;
        }


        //substract 2 numbers
        public static int Sub(int x, int y)
        {

            return x - y;
        }

        static void Main()
        {
            ParallelQuery<int> list = new List<int>(new int[100]).AsParallel();

            list.ForAll(x =>
            {
                //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                //Thread.Sleep(1 * 1000);
            });

            _add = (x,y) => {
                x = x - 2;
                return x + y;
            };

            Console.WriteLine(_add(1, 200));
            

        }
    }
}
