namespace RefactoringLab.Part02.Reports;

public interface IReportSaver
{
  void Save(string path, string content);
}