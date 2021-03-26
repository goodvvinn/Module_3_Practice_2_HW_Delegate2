using System;

namespace ExampleDelegate2
{
	public class Starter
	{
		public event Func<double, double, double> SumHandler;

		public double GeneralSum()
		{
			SumHandler += Sum;
			SumHandler += Sum;

			double result = 0;
			TryCatchMethod(() =>
			{
				foreach (var item in SumHandler.GetInvocationList())
				{
					result += (double)item.DynamicInvoke(3, 5);
				}
			});
			Console.WriteLine(result);
			return result;
		}

		public void TryCatchMethod(Action action)
		{
			try
			{
				action();
			}
			catch (Exception)
			{
				throw;
			}
		}

		private double Sum(double x, double y)
		{
			var res = x + y;
			Console.WriteLine(res);
			return res;
		}
	}
}
