namespace Module2
{
	public class Product
	{
		private static int _idCounter = 0;
		private double _price;

		public int Id { get; }
		public string Name { get; set; }
		public double Price { 
			get => _price; 
			set
			{
				_price = value;
				if (_price < 0)
					throw new ArgumentException("Price must be non negative");
			}
		}

		public Product(string name = "", double price = 0)
		{
			Id = _idCounter++;
			Name = name;
			Price = price;
		}

		public override string ToString() => $"Product(ID: {Id}, Name: {Name}, Price: {Price})";
	}
}
