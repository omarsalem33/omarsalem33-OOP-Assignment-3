namespace RefactoringLab;

public class FedExShipping:IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}