namespace RefactoringLab;

public interface IShippingCostStrategy
{
    decimal Calculate(decimal weightKg);
}