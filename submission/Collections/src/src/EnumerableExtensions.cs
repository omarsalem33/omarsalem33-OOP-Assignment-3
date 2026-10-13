namespace src;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> items, int pageNumber, int pageSize)
    {
        if(items == null)
            throw new ArgumentException(nameof(items));
        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be at least 1.");
        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be at least 1.");
        int skipCount = (pageNumber - 1) * pageSize;
        int currentIndex = 0, returnIndex = 0;
        foreach (var item in items)
        {
            if(currentIndex >= skipCount)
            {
                yield return item;
                returnIndex++; 
                if (returnIndex >= skipCount)
                    yield break;
            }
            currentIndex++;             
        }
    }

    public static T FindById<T>(this IEnumerable<T> items, int id)where T:IHasId
    {
        if (items == null)
            throw new ArgumentNullException(nameof(items));
        foreach (var item in items)
        {
            if (item != null && item.Id == id)
                return item;
        }
        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> items) where T : IHasId
    {
        if (items == null)
            throw new ArgumentNullException(nameof(items));
        
        var dictionry = new Dictionary<int, T>();
        foreach (var item in items)
        {
            if (item != null)
                dictionry.Add(item.Id, item);
        }
        return dictionry;
    }
}