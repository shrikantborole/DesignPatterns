using Facade;

Console.Title = "Facade";

Order _placeOrder = new Order(new Product(), new Payment(), new Invoice());
_placeOrder.PlaceOrder();