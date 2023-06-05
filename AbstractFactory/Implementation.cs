namespace AbstractFactory
{
    public interface IDiscountService
    {
        public int DiscountPercentage();
    }

    public class MaharashtraDiscountService : IDiscountService
    {
        public int DiscountPercentage()
        {
            return 20;
        }
    }

    public class GujrathDiscountService : IDiscountService
    {
        public int DiscountPercentage()
        {
            return 25;
        }
    }
    public interface IShippingCostService
    {
        public decimal ShippingCost();
    }

    public class MaharashtraShippingCostService : IShippingCostService
    {
        public decimal ShippingCost()
        {
            return 10;
        }
    }

    public class GujrathShippingCostService : IShippingCostService
    {
        public decimal ShippingCost()
        {
            return 5;
        }
    }

    public interface IShoppingCartPurchaseFactory
    {
        public IShippingCostService CreateShippingCostService();
        public IDiscountService CreateDiscountService();
    }

    public class MaharashtraShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new MaharashtraDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new MaharashtraShippingCostService();
        }
    }

    public class GujrathShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new GujrathDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new GujrathShippingCostService();
        }
    }

    public class ShopingCartService
    {
        private readonly IShippingCostService _shippingCostService;
        private readonly IDiscountService _discountService;
        private readonly int totalCost = 500;
        public ShopingCartService(IShoppingCartPurchaseFactory shoppingCartPurchaseFactory)
        {
            _shippingCostService = shoppingCartPurchaseFactory.CreateShippingCostService();
            _discountService = shoppingCartPurchaseFactory.CreateDiscountService();
        }
        public int Calculate()
        {
            var amountForDiscount = (totalCost * _discountService.DiscountPercentage()) / 100;
            return totalCost - amountForDiscount - Convert.ToInt32(_shippingCostService.ShippingCost());
        }
    }
}
