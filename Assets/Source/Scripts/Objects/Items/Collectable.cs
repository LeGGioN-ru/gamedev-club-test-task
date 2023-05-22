public class Collectable
{
    private readonly Item _item;
    private readonly int _amount;

    public Item Item => _item;
    public int Amount => _amount;

    public Collectable(int amount, Item item)
    {
        _amount = amount;
        _item = item;
    }
}
