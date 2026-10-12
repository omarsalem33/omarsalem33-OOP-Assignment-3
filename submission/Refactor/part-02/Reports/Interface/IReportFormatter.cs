namespace RefactoringLab.Part02.Reports;

public  interface IReportFormatter
{
    string Format(List<string[]> rows);
}