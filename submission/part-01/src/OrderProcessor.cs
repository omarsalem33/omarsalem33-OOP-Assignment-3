namespace RefactoringLab;

public class OrderProcessor
{
    private readonly IOrderRepository _repository;
    private readonly IEmailSender _emailSender;
    
    public OrderProcessor(IOrderRepository repository, IEmailSender emailSender) =>
    (_repository, _emailSender) = (repository, emailSender);

    public void Process(int orderId, string CusomerEmail)
    {
        var processedAt = DateTime.Now;
        _repository.Save(orderId, processedAt);
        _emailSender.Send(CusomerEmail,$"Order {orderId} confirmed at {processedAt}");
    }
}

public sealed class SqlOrderRepository:IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public sealed class SmtpEmailSender:IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}

public interface IOrderRepository
{
    void Save(int orderId, DateTime processedAt);
}

public interface IEmailSender
{
    void Send(string to, string body);
}