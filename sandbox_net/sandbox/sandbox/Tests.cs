
using NUnit.Framework;
using System;

namespace sandbox
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void Test1()
        {
            Console.Write("Test 1");

            Assert.IsTrue(true);
        }
    }
}
