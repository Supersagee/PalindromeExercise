using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("hello", false)]
        [InlineData("goodbye", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var test = new WordSmith();

            bool actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
