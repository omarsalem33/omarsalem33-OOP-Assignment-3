namespace RefactoringLab.Part02.Reports;

public class TextFormatter:IReportFormatter
{
    public string Format(List<string[]> rows) =>
        string.Join(Environment.NewLine, rows.Select(r => string.Join(" | ", r)));
}