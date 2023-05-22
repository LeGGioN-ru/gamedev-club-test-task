public abstract class Item
{
    private readonly int _maxInInventory;

    public int MaxInInventory => _maxInInventory;

    public Item(int maxInInventory)
    {
        _maxInInventory = maxInInventory;
    }
}
