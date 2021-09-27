using System;
using Xunit;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Theory]
        [InlineData("https://github.com/NAskjaer/BDSA-Assignment3.com", true)]
        [InlineData("https://docs.microsoft.com/en-us/dotnet/api/system.uri.urischemehttps?view=net-5.0", true)]
        [InlineData("http://docs.microsoft.com/en-us/dotnet/api/system.uri.urischemehttps?view=net-5.0", false)]
        [InlineData("http://github.com/NAskjaer/BDSA-Assignment3.com", false)]


        public void isSecureTest(string link, bool expectedOutput)
        {
            var uri = new Uri(link);
            Assert.Equal(uri.isSecure(), expectedOutput);
        }
        
        [Theory]
        [InlineData(3, "Hej med dig")]
        [InlineData(2, "HejMed Dig")]
        [InlineData(1, "HejmedDig")]
            public void wordCountTest(int count, string s)
            {
                var actual = Extensions.wordCount(s);
                Assert.Equal(count, actual);
            }
    }
}