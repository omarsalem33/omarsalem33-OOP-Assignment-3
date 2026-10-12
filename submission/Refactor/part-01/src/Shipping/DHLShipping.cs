namespace RefactoringLab;

public class DHLShipping:IShippingCostStrategy
{
    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}