using System.Threading.Channels;

namespace Module2
{
	public class Program
	{
		static void Main(string[] args)
		{
			ElectronicsProduct product1 = new ElectronicsProduct("Keyboard", 30);
			ElectronicsProduct product2 = new ElectronicsProduct("Headphones", 120);
			FoodProduct product3 = new FoodProduct("Bread", 20);
			FoodProduct product4 = new FoodProduct("Sausage", 120);

			Order order = new Order();
			order.AddProduct(product1);
			order.AddProduct(product2);
			order.AddProduct(product3);
			order.AddProduct(product4);

			Console.WriteLine("Order:");
			Console.WriteLine(order);
			Console.WriteLine("Total price:");
			Console.WriteLine(order.GetTotalPrice());
			Console.WriteLine();

			order.RemoveProduct(1);
			Console.WriteLine("After removal order:");
			Console.WriteLine(order);
			Console.WriteLine("Total price:");
			Console.WriteLine(order.GetTotalPrice());
			Console.WriteLine();

			Console.WriteLine("Removing non-existant product");
			try
			{
				order.RemoveProduct(1);
			}
			catch (ProductNotFoundException ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine("Order status change:");
			order.Status = OrderStatus.InDelivery;
			order.Status = OrderStatus.Delivered;
			order.Status = OrderStatus.Rejected;
		}
	}
}
