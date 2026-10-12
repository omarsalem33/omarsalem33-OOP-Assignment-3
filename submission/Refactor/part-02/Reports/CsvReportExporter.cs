namespace RefactoringLab.Part02.Reports;

public class CsvReportExporter
{
    private readonly ReportDataProvider _dataProvider;
    private readonly IReportFormatter  _reportFormatter;
    private readonly IReportSaver _reportSaver;

    public CsvReportExporter(ReportDataProvider  reportDataProvider, IReportFormatter reportFormatter, IReportSaver reportSaver)
    {
        _dataProvider = reportDataProvider;
        _reportFormatter = reportFormatter;
        _reportSaver = reportSaver;
    }
    public void Export(string path)
    {
        var rows = _dataProvider.GetValidatedRows();
        var content = _reportFormatter.Format(rows);
        _reportSaver.Save(path, content);
    }

}
