using NUnit.Framework;
using System;

namespace DataDrivenTest
{
    public class SharingData
    {
        [Test]
        public static string[] TestData()
        {
            return new[]
            {
            "88",
            "$88",
            "88.80",
            "88,00"
            };

        }
    }
}
