using FactoryMethod;

Console.Title = "Factory Method";
List<DiscountFactory> discountFactories = new List<DiscountFactory>();
discountFactories.Add(new CountryDiscountFatory("IND"));
discountFactories.Add(new CodeDiscountFactory(DiscountCode.BigDiscount));

foreach (var item in discountFactories)
{
    var discountService = item.CreateDiscountService();
    discountService.DiscountPercentage();
}