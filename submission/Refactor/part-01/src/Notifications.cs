namespace RefactoringLab;

// public class Notification
// {
//     public virtual void Send(string to, string message) =>
//         Console.WriteLine($"notify {to}: {message}");
// }
//
// public class EmailNotification : Notification
// {
//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[email] {to}: {message}");
// }
//
// public class SmsNotification : Notification
// {
//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[sms] {to}: {message}");
// }
//
// public class UrgentEmailNotification : EmailNotification
// {
//     public override void Send(string to, string message) =>
//         base.Send(to, $"[URGENT] {message}");
// }
//
// public class UrgentSmsNotification : SmsNotification
// {
//     public override void Send(string to, string message) =>
//         base.Send(to, $"[URGENT] {message}");
// }
//
// public class UrgentScheduledEmailNotification : UrgentEmailNotification
// {
//     public DateTime SendAt { get; set; }
//
//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[email scheduled {SendAt:g}] {to}: [URGENT] {message}");
// }
//
// public class UrgentScheduledSmsNotification : UrgentSmsNotification
// {
//     public DateTime SendAt { get; set; }
//
//     public override void Send(string to, string message) =>
//         Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
// }



public interface INotification
{
    void Send(string to, string message, DateTime sendAt );
}

public sealed class EmailNotification :INotification
{
    public void Send(string to, string message,  DateTime sendAt)
    {
        Console.WriteLine($"Email Scheduled: {to} :{message} send at {sendAt}");
    }
}

public sealed class SmsNotification:INotification
{
    public void Send(string to, string message,  DateTime sendAt)
    {
        Console.WriteLine($"Sms Scheduled: {to} :{message} send at {sendAt}");
    }
}

public sealed class NotificationsOptions
{
    public bool isUrgent { get; set; }
    public DateTime sendAt { get; set; }
}

public sealed class NotificationService
{
    private readonly INotification _notifications;

    public NotificationService(INotification notifications)
    {
        _notifications = notifications;
    }

    public void Send(string to, string message, NotificationsOptions? options = null)
    {
        options ??= new NotificationsOptions();
        if (options.isUrgent)
        {
            message = $"[Urgent] {message}]";
        }
        _notifications.Send(to, message,options.sendAt);
    }
}
