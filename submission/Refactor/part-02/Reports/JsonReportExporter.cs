namespace RefactoringLab.Part02.Reports;

public class JsonReportExporter
{
    private readonly ReportDataProvider _dataProvider;
    private readonly IReportFormatter  _reportFormatter;
    private readonly IReportSaver _reportSaver;

    public JsonReportExporter(ReportDataProvider dataProvider, IReportFormatter reportFormatter, IReportSaver reportSaver)
    {
        _dataProvider = dataProvider;
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
