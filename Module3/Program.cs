using System.Xml.Serialization;

namespace Module3
{
	public class Program
	{
		static void Main(string[] args)
		{
			string sourceDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			string readFromFilepath = sourceDirectory + @"\employees.xml";

			EmployeeCollection employees = EmployeeCollection.DeserializeFromXml(readFromFilepath);
			Console.WriteLine("Employees:");
			Console.WriteLine(employees);
			
			EmployeeCollection employeesSorted = new EmployeeCollection()
			{
				Employees = employees.Employees.OrderBy(employee => employee.HireDate).ToList()
			};

			Console.WriteLine("\nSorted employees:");
			Console.WriteLine(employeesSorted);
			employeesSorted.SerializeToXml(sourceDirectory + @"\sorted_employees.xml");

			employees.WriteToTxtFile(sourceDirectory + @"\employees.txt");
		}
	}
}
