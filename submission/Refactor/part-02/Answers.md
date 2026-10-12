# Part 02 — Answers

## Reports

### What was the problem?
The `CsvReportExporter` class had multiple responsibilities, including loading data, validating data, formatting the report, and saving the file. Also, the exporter was directly creating its formatter and saver objects, which made it tightly coupled to specific implementations. Supporting different formats such as CSV, JSON, and Text could lead to duplicated code and make the system harder to extend.

### What did you change?
I separated the responsibilities into different classes: `ReportDataLoader` for loading data, `ReportValidator` for validating data, different formatter classes for CSV, JSON, and Text, and `SaveReport` for saving the report. I introduced the `IReportFormatter` and `IReportSaver` interfaces and used dependency injection to provide the required dependencies to the exporters.

### Why did you choose that approach?
I chose this approach to follow the Single Responsibility Principle (SRP) by giving each class a specific responsibility. I also applied the Dependency Inversion Principle (DIP) by making the exporters depend on interfaces instead of concrete implementations. This design makes the code easier to maintain, test, and extend when adding new report formats or saving methods.

---

## Enrollment

### What was the problem?
The enrollment components, such as `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService`, handle different responsibilities. If the enrollment-processing class creates these dependencies directly, it becomes tightly coupled to their concrete implementations. This makes it harder to replace services, test the enrollment process, or extend the system.

### What did you change?
I kept the payment, seat reservation, invoice generation, and email functionality in separate classes. I would use interfaces for the required services and inject them into the enrollment-processing class through its constructor instead of creating the dependencies inside it.

### Why did you choose that approach?
I chose this approach to separate responsibilities and reduce coupling between the enrollment process and its supporting services. It follows the Single Responsibility Principle (SRP) and Dependency Inversion Principle (DIP), making the system easier to test, maintain, and extend when a service needs to be replaced or a new feature is added.