namespace Module2
{
	public interface IOrder
	{
		public void AddProduct(Product product);
		public void RemoveProduct(int id);
		public double GetTotalPrice();
	}
}
