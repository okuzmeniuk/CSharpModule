namespace Module2
{
	public class FoodProduct : Product
	{
		public FoodProduct(string name = "", double price = 0) : base(name, price) { }
		public override string ToString() => $"FoodProduct(ID: {Id}, Name: {Name}, Price: {Price})";
	}
}
