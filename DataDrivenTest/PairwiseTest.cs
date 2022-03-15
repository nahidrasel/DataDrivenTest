using NUnit.Framework;
using System;

namespace DataDrivenTest
{
    public class ParameterizedTest
    {
        private int price;

        [Test]
        [Sequential]
        public void RangeAttributes(
            [Values("9,99")] string Number,
            [Range(100, 1000)]int price)
        { 
        }
public ParameterizedTest(int price)
        {
            this.price = price;
        }
    }
    [TestCase("9","99")]
    public void Addrooms( string Number, int price ) 
    {

    }
    [TestCase(2,2,ExpectedResult =4)]
    public void AddRoom(string Number, int price)
    {

    }


}
