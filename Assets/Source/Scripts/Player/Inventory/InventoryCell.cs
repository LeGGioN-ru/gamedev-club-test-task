public class InventoryCell
{
    private int _amount;
    private Item _item;

    public Item Item => _item;
    public int Amount => _amount;

    public InventoryCell(Item item)
    {
        _item = item;
    }

    public void AddItem(int amount)
    {
        _amount += amount;
    }
}
