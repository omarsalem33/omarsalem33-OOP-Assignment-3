# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
- `Answer`: The original `ShippingCostCalculator` violated the Open-Closed Principle (OCP) because adding a new shipping carrier required modifying the existing `switch` statement.

- What did you change?
- `Answer`: I refactored `ShippingCostCalculator` using the Strategy Pattern. I created an `IShippingCostStrategy` interface and separate classes for each shipping carrier. Now, I can add a new carrier without modifying the existing calculator or carrier classes.

---

## OrderProcessor

- What was the problem?
- `Answer`: The `OrderProcessor` was tightly coupled to `SqlOrderRepository` and `SmtpEmailSender` because it created these objects directly inside the `Process` method. This made the class difficult to test and extend because changing the storage or email implementation required modifying the `OrderProcessor`.

- What did you change?
- `Answer`: I created the `IOrderRepository` and `IEmailSender` interfaces and made the existing classes implement them. I refactored `OrderProcessor` to receive its dependencies through constructor injection instead of creating them directly. This follows the Dependency Inversion Principle (DIP) and makes the class easier to test and extend.

---

## Notifications

- What was the problem?
- `Answer`: The original notification classes misused inheritance by combining notification channels (Email and SMS) with delivery behaviors (Urgent and Scheduled). This caused code duplication and a combinatorial explosion of classes because each new channel or behavior combination could require another class.

- What did you change?
- `Answer`: I refactored the notification design using composition over inheritance. I introduced the `INotificationChannel` interface, separate channel implementations, and a `NotificationOptions` class to represent urgency and scheduling options. I created a `NotificationService` to combine the selected channel with these options. This allows Email, SMS, and new notification channels to support urgent, scheduled, or both behaviors without creating a separate class for every combination.

---

## Proof

- New carrier file(s):
- `UPSShipping.cs` (implements `IShippingCostStrategy`).

- New notification channel file(s):
- `WhatsAppNotification.cs` (implements `INotificationChannel`).

- Existing classes left unchanged? (yes/no):
- `No`. I modified the existing `ShippingCostCalculator`, `OrderProcessor`, and notification classes as part of the refactoring. However, the existing carrier and notification channel implementations do not need to be modified when adding new carriers or channels. Only `Program.cs` needs to be updated to wire in the new implementations.