namespace Strategy
{
	public interface IExportService
	{
		public void Export(Order order);
	}

    public class Order
    {
        public Order(int orderId, string orderName)
        {
            OrderId = orderId;
            OrderName = orderName;
        }
		public int OrderId { get; set; }
		public string? OrderName { get; set; }

		public void Export(IExportService service)
		{
			if (service == null)
				throw new ArgumentException();
			service.Export(this);
		}
	}

    public class CSVExportService : IExportService
    {
        public void Export(Order order)
        {
			Console.WriteLine($"CSVExportService => {order.OrderId} {order.OrderName}");
        }
    }

    public class XMLExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"XMLExportService => {order.OrderId} {order.OrderName}");
        }
    }

    public class JSONExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"JSONExportService => {order.OrderId} {order.OrderName}");
        }
    }
}
