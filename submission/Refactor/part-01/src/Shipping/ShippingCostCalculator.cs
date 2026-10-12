namespace RefactoringLab;

public sealed class ShippingCostCalculator
{
    private readonly IShippingCostStrategy _strategies;
    public ShippingCostCalculator(IShippingCostStrategy  strategy)
    {
        _strategies = strategy;
    }

    public decimal Calculate(decimal weightKg)
    {
        return _strategies.Calculate(weightKg);
    }
}
