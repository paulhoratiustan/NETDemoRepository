using System;
using NUnit.Framework;

namespace DemoProject
{
    [TestFixture]
    class DemoTest
    {
        [Test]
        public void Test1()
        {
            //failled
            var x = new Random().Next();
            Console.WriteLine(x);
            Assert.AreEqual(x+3, Program.Add(x, 3));
        }

        [Test]
        public void Test2()
        {
            //passed
            var x = new Random().Next();
            Console.WriteLine(x);
            Assert.GreaterOrEqual(x, Program.Sub(x, 10));
        }
    }
}
