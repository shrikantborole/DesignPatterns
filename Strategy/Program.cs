using Strategy;
Console.Title = "Strategy";

Order order= new Order(1,"Apple-Order");
order.Export(new CSVExportService());
Console.WriteLine("-------------------------");
order.Export(new XMLExportService());
Console.WriteLine("-------------------------");
order.Export(new JSONExportService());
