using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
	[Serializable]
	public class Employee
	{
		public string Name { get; set; }
		public string Position { get; set; }
		public DateTime HireDate { get; set; }

		public Employee()
		{
			Name = "";
			Position = "";
			HireDate = DateTime.Now;
		}

		public override string ToString()
		{
			return $"Name: {Name} Position: {Position} HireDate: {HireDate.ToString("yyyy-MM-dd")}";
		}
	}
}
