using System.Text;

namespace Iterator;

public class ShopingList
{
    private List<string> _items = new List<string>();
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder("Items: \r\n");
        _items.ForEach(item => sb.Append($"{item}\r\n"));
        return sb.ToString();
    }

    public void Push(string item) => _items.Add(item); 
    
    public string Pop()
    {
       string item = _items.Last();
       _items.Remove(item);
       return item;
    }

    public List<string> GetItems() => _items;
}
