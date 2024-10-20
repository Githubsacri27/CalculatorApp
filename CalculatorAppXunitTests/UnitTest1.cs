using Xunit;

namespace CalculatorApp.XunitTests
{
    public class CalculatorXunitTests
    {

        ICalculator icalculator = new Calculator();
        
        

        [Fact]
        public void DivideTest()
        {
            Assert.Equal(4, icalculator.Sum(2, 2));
        }

        [Fact]
        public void MultiplicationTest()
        {
            Assert.True(icalculator.Multiply(3, 6) == 18);
        }

        [Fact]
        public void SubtractTest()
        {
            Assert.False(icalculator.Subtract(5, 3) == 10);
        }

        [Fact]
        public void SumTest()
        {
            Assert.False(icalculator.Sum(2, 2) == 6);
        }

    }
}