using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> range = Enumerable.Range(1, 10);
			foreach(int i in range)
			{
				Console.WriteLine(i);
			}
	}   }
}
