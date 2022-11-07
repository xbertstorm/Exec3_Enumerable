using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> number = Enumerable.Range(10, 6);

			foreach (var x in number)
			{
				Console.WriteLine(x);
			}
		}
	}
}
