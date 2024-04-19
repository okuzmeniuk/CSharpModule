namespace Module2
{
	public class ProductsList<T>
	{
		public List<T> Items { get; set; } = new List<T>();
		public void AddElement(T element) => Items.Add(element);
	}
}
