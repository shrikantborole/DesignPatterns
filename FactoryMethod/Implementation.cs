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
                case "IND":
                    Console.WriteLine("IND");
                    return 30;
                case "US":
                    Console.WriteLine("US");
                    return 20;
                default:
                    return 0;
            }
        }
    }

    class CodeDiscountService : IDiscountService
    {
        DiscountCode _codeCode;
        public CodeDiscountService(DiscountCode codeCode)
        {
            _codeCode = codeCode;
        }
        public int DiscountPercentage()
        {
            switch (_codeCode)
            {
                case DiscountCode.BigDiscount:
                    Console.WriteLine("BigDiscount");
                    return 89;
                case DiscountCode.SmallDiscount:
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
        DiscountCode _codeCode;

        public CodeDiscountFactory(DiscountCode codeCode)
        {
            _codeCode = codeCode;
        }

        public override IDiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_codeCode);
        }
    }

    enum DiscountCode
    {
        BigDiscount,
        MediumDiscount,
        SmallDiscount
    }
}
