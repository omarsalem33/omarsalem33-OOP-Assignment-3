namespace RefactoringLab.Part02.Reports;

public class ReportDataProvider
{
    private readonly ReportDataLoader _loader;
    private readonly ReportValidator _validator;

    public ReportDataProvider(ReportDataLoader loader, ReportValidator validator)
    {
        _loader = loader;
        _validator = validator;
    }

    public List<string[]> GetValidatedRows()
    {
        var rows = _loader.Load();
        if (!_validator.Validate(rows))
        {
            throw new InvalidOperationException("Invalid data");
        }
        return rows;
    }
    
}