namespace RefactoringLab;

public class AramexShipping:IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}