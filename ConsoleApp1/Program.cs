using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = new List<Product>()
			{
				new Product{ Name = "water ",Price = 10 },
				new Product{Name = "beer",Price = 30 },
			};
		}
	}
	class Product
	{
		public string Name { get; set; }
		public int Price { get; set; }

	}
}
