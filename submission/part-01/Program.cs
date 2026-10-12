using RefactoringLab;


#region refactoring 

// var shipping = new ShippingCostCalculator();
// Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
// Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
// Console.WriteLine();

var shippingAramex = new ShippingCostCalculator(new AramexShipping());
Console.WriteLine($"Aramex shipping cost: {shippingAramex.Calculate(2)}");

var shippingFedEx = new ShippingCostCalculator(new FedExShipping());
Console.WriteLine($"FedEx shipping cost: {shippingFedEx.Calculate(2)}");

Console.WriteLine();
#endregion

#region refactoring Order

var repo = new SqlOrderRepository();
var emailSender =new SmtpEmailSender();

var processor = new OrderProcessor(repo, emailSender);
processor.Process(1001, "customer@example.com");
Console.WriteLine();
#endregion

#region Notification Refactoring
// new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) }
//     .Send("customer@example.com", "Your order ships tomorrow");
// new UrgentSmsNotification()
//     .Send("+201000000000", "OTP 4821");


var emailNotificationUrgent = new NotificationService(new EmailNotification());
emailNotificationUrgent.Send("Omar@gmail.com",
    "Your order ships tomorrow",new NotificationsOptions { isUrgent = true});

var smsNotificationUrgent = new NotificationService(new SmsNotification());
smsNotificationUrgent.Send("201000000000", 
    "OTP 4821" , new NotificationsOptions { isUrgent = true });

var emailNotificationScheduled = new NotificationService(new EmailNotification());
emailNotificationScheduled.Send("Omar@gmial.com",
    "Your order ships next monday",new NotificationsOptions(){
    sendAt = new DateTime(2026, 10, 15, 14, 30, 0)
});
#endregion