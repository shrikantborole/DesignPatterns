using FactoryMethod;

Console.Title = "Factory Method";
List<DiscountFactory> discountFactories = new List<DiscountFactory>();
discountFactories.Add(new CountryDiscountFatory("BE"));
discountFactories.Add(new CodeDiscountFactory(Discount.BigDiscount));

foreach (var item in discountFactories)
{
    var discountService = item.CreateDiscountService();
    discountService.DiscountPercentage();
}