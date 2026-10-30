namespace RefactoringLab.Part02.Reports;

public class SaveReport:IReportSaver
{
    public void Save(string path, string content) =>
        File.WriteAllText(path, content);
}