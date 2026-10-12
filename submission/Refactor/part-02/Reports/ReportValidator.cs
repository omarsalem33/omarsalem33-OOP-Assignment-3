namespace RefactoringLab.Part02.Reports;

public class ReportValidator
{
    public  bool  Validate(List<string[]> rows) =>
        rows.Count > 1 && rows[0].Length > 0;
}