namespace Strategy.Core.DiscountStrategies;

public class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalculateDiscount(decimal price) =>  price >= 10000 ?  0.1m : 0;
}
