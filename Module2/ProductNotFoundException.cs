using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
	public class ProductNotFoundException : Exception
	{
		public ProductNotFoundException() { }
		public ProductNotFoundException(string? message) : base(message) {}
	}
}
