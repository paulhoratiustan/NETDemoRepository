using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("x=");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y=");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x + y = " + Add(x, y));
        }
    }
}
