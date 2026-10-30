using RefactoringLab.Part02.Enrollment;
using RefactoringLab.Part02.Reports;

Console.WriteLine("=== Reports ===");
var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
Directory.CreateDirectory(outDir);

// new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
// new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
// new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));

var loader = new ReportDataLoader();
var validator = new ReportValidator();
var dataProvider = new ReportDataProvider(loader, validator);
IReportSaver saver = new SaveReport();

var csvExporter = new CsvReportExporter(dataProvider, new CsvFormatter(), saver);
var jsonExporter = new JsonReportExporter(dataProvider, new CsvFormatter(), saver);
var textExporter = new TextReportExporter(dataProvider, new CsvFormatter(), saver);



Console.WriteLine($"Wrote reports to {outDir}");
Console.WriteLine();

Console.WriteLine("=== Enrollment ===");
var studentId = "S100";
var courseId = "CS201";
var amount = 1500m;

var payment = new PaymentGateway();
var seats = new SeatInventory();
var invoices = new InvoiceGenerator();
var email = new EmailService();

payment.Charge(studentId, amount);
seats.Reserve(courseId, studentId);
var invoiceId = invoices.Create(studentId, amount);
email.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
