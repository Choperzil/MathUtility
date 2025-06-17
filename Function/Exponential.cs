using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
	public class Exponential
	{
		/// <summary>
		/// The function that helps calculate exponential function
		/// </summary>
		/// <param name="a">Enter a double</param>
		/// <param name="b">Enter a integer</param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static double power(double a, int b)
		{
			double result = 1;

			if (a == 0 && b == 0)
				throw new ArgumentException("a or b must bigger than 0");

			if (b < -1000 || b > 1000)
				throw new ArgumentException("Value b is out of range");

			if (b == 0)
				return 1;

			if (b < 0)
				for (int i = 1; i <= -b; i++)
					result *= 1 / a;
			else
				for (var i = 1; i <= b; i++)
					result *= a;
			
			return result;
		}
	}
}
