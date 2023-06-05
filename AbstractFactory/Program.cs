using AbstractFactory;

Console.Title = "Abstract Factory";

IShoppingCartPurchaseFactory shoppingCartPurchaseFactory = new MaharashtraShoppingCartPurchaseFactory();
ShopingCartService shopingCartService1 =
    new ShopingCartService(shoppingCartPurchaseFactory);
Console.WriteLine(shopingCartService1.Calculate());

shoppingCartPurchaseFactory = new GujrathShoppingCartPurchaseFactory();
ShopingCartService shopingCartService2 =
    new ShopingCartService(shoppingCartPurchaseFactory);
Console.WriteLine(shopingCartService2.Calculate());

Console.WriteLine("Press key to exit !!");

