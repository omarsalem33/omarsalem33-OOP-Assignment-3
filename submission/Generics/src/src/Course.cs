namespace src;

public class Course:IHasId
{
    public Course(int id, string title, decimal price)
    {
        Id = id;
        Title = title;
        Price = price;
    }

    public int Id { get; set; }

    public string Title { get; set; }
    public decimal Price { get; set; }
    
}
