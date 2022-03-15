using System;
using NUnit.Framework;

namespace DataDrivenTest
{
    public class TheoryAttributes
    {

        [Test]
        [DatapointSource]
        public void TheoryTest()
        {
            var attributes = new TheoryAttributes();

            Console.WriteLine("Theory is a special type of test used to verify " +
                "a general statement about the system under development.");
        }
    }
}
