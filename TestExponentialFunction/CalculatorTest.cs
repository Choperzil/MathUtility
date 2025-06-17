using Function;

namespace TestExponentialFunction
{

	public class CalculatorTest
	{
		[Theory]
		[InlineData(2, 2, 4)]
		[InlineData(3, 5, 243)]
		[InlineData(3.4, 3, 39.304)]
		[InlineData(5, 0, 1)]
		[InlineData(10, 1, 10)]
		[InlineData(-2, 3, -8)]
		public void testExponentialReturnsRight(double a, int b, double expected)
		{
			double result = Exponential.power(a, b);
			Assert.Equal(result, expected, 5);
		}

		[Fact]
		public void testExponentialReturnsException()
		{
			var ex = Assert.Throws<ArgumentException>(() => Exponential.power(0, 0));
			Assert.Equal("a or b must bigger than 0", ex.Message);
		}

		[Theory]
		[InlineData(2, 1001)]
		[InlineData(2, -1001)]
		public void testExponentialReturnsException1(double a, int b)
		{
			var ex = Assert.Throws<ArgumentException>(() => Exponential.power(a, b));
			Assert.Equal("Value b is out of range", ex.Message);
		}

	}
}