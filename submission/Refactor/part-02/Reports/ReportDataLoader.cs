namespace RefactoringLab.Part02.Reports;

public  class ReportDataLoader
{
    public  List<string[]> Load()
    {
        return new List<string[]>
        {
            new[] { "Id", "Name" },
            new[] { "1", "Keyboard" },
            new[] { "2", "Mouse" },
        };
    }
}