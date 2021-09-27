using System;
using Xunit;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {      

        [Theory]
        [InlineData("abcd","dcba")]
        [InlineData("Hejsa","asjeH")]
        [InlineData("kartoffel","leffotrak")]
        [InlineData("Hej med dig mit navn er Kaj", "jaK re nvan tim gid dem jeH")]
        public void reverseStringTest(string input, string expectedOutput)
        {
            
           
           Func<string,string> reversed = (input) => 
           {
                var inputArray = input.ToCharArray();
                Array.Reverse(inputArray);
                var reversedInput = new string(inputArray);
                return reversedInput;
           }; 

            Assert.Equal(expectedOutput, reversed(input));
        }

        [Theory]
        [InlineData(1.2, 4.2, 5.04)]
        [InlineData(22.1, 4.6, 101.66)]
        [InlineData(3.0, 3.0, 9.0)]

        public void product(decimal x, decimal y, decimal expectedOutput)
        {

            Func<decimal, decimal, decimal> productOfNumbers = (x, y) => x * y;
            var product = productOfNumbers(x, y);
            Assert.Equal(expectedOutput, product);
    
        }

    [Theory]
    [InlineData("1234",42,false)]
    [InlineData("0580",42,false)]
    [InlineData("00042000",42,false)]
    [InlineData("00042",42,true)]
    public void numEqualTest(string inputString, int inputInt, bool expected)
    {

        Func<string, int, bool> numEqual = (string s, int i) => {
            return Int32.Parse(s) == i;
        };

        bool actual = numEqual(inputString,inputInt);

        Assert.Equal(expected,actual);
        

    }
}
}
