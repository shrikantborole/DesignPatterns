namespace FactoryMethod
{
    interface IDiscountService
    {
        public int DiscountPercentage();
    }

    class CountryDiscountService : IDiscountService
    {
        string _countryCode;
        public CountryDiscountService(string countryCode)
        {
            _countryCode = countryCode;
        }
        public int DiscountPercentage()
        {
            switch (_countryCode)
            {
                case "BE":
                    Console.WriteLine("BE");
                    return 30;
                case "ME":
                    Console.WriteLine("ME");
                    return 20;
                default:
                    return 0;
            }
        }
    }

    class CodeDiscountService : IDiscountService
    {
        Discount _codeCode;
        public CodeDiscountService(Discount codeCode)
        {
            _codeCode = codeCode;
        }
        public int DiscountPercentage()
        {
            switch (_codeCode)
            {
                case Discount.BigDiscount:
                    Console.WriteLine("BigDiscount");
                    return 89;
                case Discount.SmallDiscount:
                    Console.WriteLine("SmallDiscount");
                    return 29;
                default:
                    return 0;
            }
        }
    }

    abstract class DiscountFactory
    {
        public abstract IDiscountService CreateDiscountService();
    }

    class CountryDiscountFatory : DiscountFactory
    {
        string _countryCode;
        public CountryDiscountFatory(string countryCode)
        {
            _countryCode= countryCode;
        }
        public override IDiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryCode);
        }
    }

    class CodeDiscountFactory : DiscountFactory
    {
        Discount _codeCode;

        public CodeDiscountFactory(Discount codeCode)
        {
            _codeCode = codeCode;
        }

        public override IDiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_codeCode);
        }
    }

    enum Discount
    {
        BigDiscount,
        SmallDiscount
    }
}
