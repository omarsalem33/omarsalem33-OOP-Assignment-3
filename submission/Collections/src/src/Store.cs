namespace src;

public class Store<T>where T :IHasId
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T GetById(int id)
    {
        foreach (var item in _items)
        {
            if (item.Id == id)
                return item;
        }
        return default(T);
    }
    public List<T> GetAll()
        => _items;

    public void Remove(T item)
    {
        if(GetById(item.Id) != null)
            _items.Remove(item);
    }
    
}