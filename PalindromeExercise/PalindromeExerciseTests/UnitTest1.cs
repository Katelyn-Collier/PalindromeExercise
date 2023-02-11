using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("LeveL" , true)]
        [InlineData("CiviC", true)]
        [InlineData("katelyn", false)]
        public void Test1(string word, bool expected)
        {
            var tester = new WordSmith();

            bool actual = tester.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
