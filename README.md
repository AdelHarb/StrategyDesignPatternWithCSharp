# StrategyDesignPatternWithCSharp

# This is a simple example of the Strategy Design Pattern using C#.

# This code is taken from Passionate Coders YouTube Channel for demonstration the Pattern.

    https://www.youtube.com/watch?v=MdB6zKDeb44&list=PLsV97AQt78NTrqUAZM562JbR3ljX19JFR&index=4



It is behavioral design pattern that enables selecting an algorithm at runtime based on some input parameters.

Those Inputs sometimes based on user options or some system decision.

for example: Sorting algorithms, there are different implementation of the sorting but the output is the same.
             Saving Files in different formats.
             Customer Discounts based on the customer type (Gold, Silver, Bronze).
             Payment Methods (Cash, Credit Card, PayPal, etc.).

# To Implement this pattern: 

1- Create an interface or abstract class with the common methods.
    In our case we have ICustomerDiscountSTrategy interface with CalculateDiscount() method.


2- Create concrete classes that implement the interface or abstract class.
    in out case we have the following classes:
    - GoldCustomerDiscountStrategy
    - SilverCustomerDiscountStrategy

3- Create a context class that has a reference to the interface or abstract class.
    In our case we have CustomerDiscountContext class that has a reference to ICustomerDiscountStrategy interface.

4- In The context class which is InvoiceManager class, we have a method "SetCustomerDiscountStrategy" that takes an object of type ICustomerDiscountStrategy.
    This method is used to set the strategy at runtime.