namespace Strategy.Core.DiscountStrategies;

public interface ICustomerDiscountStrategy
{
    decimal CalculateDiscount(decimal price);
}