namespace Module2
{
	public class ElectronicsProduct : Product
	{
        public ElectronicsProduct(string name = "", double price = 0) : base(name, price) {}

        public override string ToString() => $"ElectronicsProduct(ID: {Id}, Name: {Name}, Price: {Price})";
	}
}
