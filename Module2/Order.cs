namespace Module2
{
	public enum OrderStatus
	{
		InProcess,
		InDelivery,
		Delivered,
		Rejected
	}

	public class Order : IOrder
	{
		private OrderStatus _status;

		public event EventHandler<OrderStatus>? OrderStatusChanged;
		public ProductsList<Product> Products { get; set; }
		public OrderStatus Status
		{
			get => _status;
			set
			{
				OrderStatus newStatus = value;

				if (_status != newStatus)
				{
					OrderStatusChanged?.Invoke(this, newStatus);
				}
				_status = newStatus;
			}
		}

		private string OrderStatusToString(OrderStatus status) => status switch
		{
			OrderStatus.InProcess => "In process",
			OrderStatus.InDelivery => "In delivery",
			OrderStatus.Delivered => "Delivered",
			OrderStatus.Rejected => "Rejected",
			_ => "Unknown"
		};

		public Order()
		{
			Products = new ProductsList<Product>();
			Status = OrderStatus.InProcess;
			SubscribeToOrderStatusChanged(OnOrderStatusChange);
		}

		public void SubscribeToOrderStatusChanged(EventHandler<OrderStatus>? handler) => OrderStatusChanged += handler;
		public void UnsubscribeFromOrderStatusChanged(EventHandler<OrderStatus>? handler) => OrderStatusChanged -= handler;

		public void OnOrderStatusChange(object sender, OrderStatus newOrderStatus)
		{
			Order? order = sender as Order;
			Console.WriteLine($"Order status changed from {OrderStatusToString(order.Status)} to {OrderStatusToString(newOrderStatus)}");
		}

		public void AddProduct(Product product) => Products.AddElement(product);

		public double GetTotalPrice() => Products.Items.Sum(p => p.Price);

		public void RemoveProduct(int id)
		{
			int amountRemoved = Products.Items.RemoveAll(p => p.Id == id);
			if (amountRemoved == 0)
				throw new ProductNotFoundException($"Product item with id {id} was not present in order");
		}

		public override string ToString()
		{
			string toReturn = "Order status:";

			toReturn += OrderStatusToString(Status);

			toReturn += string.Join('\n', Products.Items.Select(p => p.ToString()));
			return toReturn;
		}
	}
}
