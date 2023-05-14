namespace Strategy.Core;

public class Invoice
{
    public Customer Customer { get; set; }
    public IEnumerable<Item> Items { get; set; }
    public decimal Total => Items.Sum(i => i.Quantity * i.Price);
    public decimal DiscountPercentage { get; set; }
    public decimal NetTotal => Total - (Total * DiscountPercentage);
}