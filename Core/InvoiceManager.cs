using Strategy.Core.DiscountStrategies;

namespace Strategy.Core;

public class InvoiceStrategy
{
    private ICustomerDiscountStrategy _customerDiscountStrategy; 
    public void SetDiscountStrategy(ICustomerDiscountStrategy discountStrategy)
    {
        _customerDiscountStrategy = discountStrategy;
    }
    public Invoice CreateInvoice(Customer customer, int quantity, decimal price)
    {
        var invoice = new Invoice
        {
            Customer = customer,
            Items = new List<Item>
            {
                new Item
                {
                    Quantity = quantity,
                    Price = price
                }
            }
        };

        invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDiscount(invoice.Total);
        return invoice;
    }
}