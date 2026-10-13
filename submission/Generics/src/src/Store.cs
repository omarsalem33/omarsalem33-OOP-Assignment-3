namespace src;

public class Store<T>where T :IHasId
{
    private Dictionary<int,T> _items = new Dictionary<int, T>();

    public void Add(T item)
    {
        if(_items.ContainsKey(item.Id))
            throw new ArgumentException($"An item with Id {item.Id} already exists.", nameof(item));
        
        _items.Add(item.Id,item);
        
    }

    public T GetById(int id)
    {
        return _items.ContainsKey(id) ? _items[id]: default(T);
    }
    public IReadOnlyCollection<T> GetAll()
        => _items.Values;

    public void Remove(T item)
    {
        _items.Remove(item.Id);
    }
    
}