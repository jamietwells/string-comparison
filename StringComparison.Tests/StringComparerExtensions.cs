using System;
using System.Globalization;
using Xunit;

namespace StringComparison.Tests
{
    public class StringComparerExtensions
    {

        CompareOptions options = CompareOptions.IgnoreNonSpace;
        [Fact]
        public void TwoEqualStringsAreEqual()
        {
            Assert.True("ABC".Contains("ABC", options));
        }

        [Fact]
        public void TwoUnequalStringsAreNotEqual()
        {
            Assert.False("A".Contains("B", options));
        }

        [Fact]
        public void ASubStringIsTrue()
        {
            Assert.True("ABCD".Contains("BC", options));
        }

        [Fact]
        public void ANotSubStringIsFalse()
        {
            Assert.False("ABCD".Contains("AD", options));
        }

        [Fact]
        public void CultureIsIgnored()
        {
            Assert.True("é".Contains("e", options));
        }

        [Fact]
        public void CultureIsIgnoredForWholeWords()
        {
            Assert.True("hélló there".Contains("hello", options));
        }
    }
}
