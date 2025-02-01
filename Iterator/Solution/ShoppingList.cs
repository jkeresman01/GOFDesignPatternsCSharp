namespace Iterator.Solution;

public class ShoppingList
{
    public IList<string> Items { get; set; }

    public ShoppingList()
    {
        Items = new List<string>();
    }

    public void Push(string item) => Items.Add(item);

    public string Pop()
    {
        var lastItem = Items.Last();
        Items.Remove(lastItem);
        return lastItem;
    }
    
    public IIterator<string> CreateIterator() => new ListIterator(this);
    
    private class ListIterator : IIterator<string>
    {
        private ShoppingList _shoppingList;
        private int _currentIndex;

        public ListIterator(ShoppingList shoppingList)
        {
            _shoppingList = shoppingList;
        }

        public void Next() => _currentIndex++;

        public bool HasNext() => _currentIndex < _shoppingList.Items.Count;
        
        public string Current() => _shoppingList.Items[_currentIndex];
    }
}