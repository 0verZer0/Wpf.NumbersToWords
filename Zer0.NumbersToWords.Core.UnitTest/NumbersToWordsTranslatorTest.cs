using Xunit;

namespace Zer0.NumbersToWords.Core.UnitTest
{
    public class NumbersToWordsTranslatorTest
    {
        [Theory]
        [InlineData(1, "one")]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(-5, "minus five")]
        [InlineData(-11, "minus eleven")]
        [InlineData(-15, "minus fifteen")]
        [InlineData(-46, "minus forty-six")]
        [InlineData(123, "one hundred and twenty-three")]
        [InlineData(4978, "four thousand nine hundred and seventy-eight")]
        [InlineData(16978, "sixteen thousand nine hundred and seventy-eight")]
        [InlineData(302978, "three hundred and two thousand nine hundred and seventy-eight")]
        [InlineData(2000000, "two million")]
        public void TestToWords(int value, string result) 
        {
            Assert.Equal(value.ToWords(), result);
        }
    }
}
