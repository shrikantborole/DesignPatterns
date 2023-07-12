namespace Facade
{
    public interface IProduct
    {
        void ProductDetails();
    }

    public interface IPayment
    {
        void Payment();
    }
    public interface IInvoice
    {
        void CreateInvoice();
    }

    public class Product : IProduct
    {
        void IProduct.ProductDetails()
        {
            Console.WriteLine("Implementation related to order - Discount, Shipping charges, Customer related charges, etc");
        }
    }

    public class Invoice : IInvoice
    {
        public void CreateInvoice()
        {
            Console.WriteLine("Implementation related to the invoice creation");
        }
    }

    class Payment : IPayment
    {
        void IPayment.Payment()
        {
            Console.WriteLine("Implementation related to the Payment details - method and all");
        }
    }

    public class Order
    {
        private readonly IProduct _product;
        private readonly IPayment _payment;
        private readonly IInvoice _invoice;

        public Order(IProduct product, IPayment payment, IInvoice invoice)
        {
            this._product = product;
            this._payment = payment;
            this._invoice = invoice;
        }

        public void PlaceOrder()
        {
            _product.ProductDetails();
            _invoice.CreateInvoice();
            _payment.Payment();
            Console.WriteLine("All done !!");
        }
    }

}
