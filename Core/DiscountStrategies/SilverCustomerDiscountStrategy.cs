namespace Strategy.Core.DiscountStrategies;

public class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalculateDiscount(decimal price) =>  price >= 10000 ?  0.05m : 0;
}