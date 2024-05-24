using System.Xml.Serialization;

namespace Module3
{
	[Serializable]
	[XmlRoot("Employees")]
	public class EmployeeCollection
	{
		[XmlElement("Employee")]
		public List<Employee> Employees { get; set; }

		public EmployeeCollection()
		{
			Employees = new List<Employee>();
		}

		public static EmployeeCollection DeserializeFromXml(string filepath)
		{
			EmployeeCollection employees;

			XmlSerializer serializer = new XmlSerializer(typeof(EmployeeCollection));
			using (StreamReader reader = new StreamReader(filepath))
			{
				employees = serializer.Deserialize(reader) as EmployeeCollection ?? new EmployeeCollection();
			}

			return employees;
		}

		public void SerializeToXml(string filepath)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(EmployeeCollection));
			using (StreamWriter writer = new StreamWriter(filepath))
			{
				serializer.Serialize(writer, this);
			}
		}

		public void WriteToTxtFile(string filepath)
		{
			using (StreamWriter writer = new StreamWriter(filepath))
			{
				Employees.ForEach(employee => writer.WriteLine(employee.ToString()));
			}
		}

		public override string ToString()
		{
			return string.Join("\n", Employees);
		}
	}
}
