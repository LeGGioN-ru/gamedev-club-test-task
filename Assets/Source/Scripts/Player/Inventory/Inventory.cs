using System.Collections.Generic;

public class Inventory
{
    private readonly List<InventoryCell> _inventoryCells = new List<InventoryCell>();
    private readonly int _maxItems;

    public Inventory(int maxItems)
    {
        _maxItems = maxItems;
    }

    public bool TryAddItem(Collectable collectable)
    {
        if (IsExistCellStack(collectable, out InventoryCell inventoryCell))
        {
            inventoryCell.AddItem(collectable.Amount);
            return true;
        }

        if (_inventoryCells.Count + collectable.Amount > _maxItems)
            return false;

        _inventoryCells.Add(new InventoryCell(collectable.Item));

        return true;
    }

    private bool IsExistCellStack(Collectable collectable, out InventoryCell inventoryCell)
    {
        inventoryCell = _inventoryCells.Find(itemCell => itemCell.Item.Equals(collectable));

        if (inventoryCell == null || inventoryCell.Amount + collectable.Amount > inventoryCell.Item.MaxInInventory)
            return false;

        return true;
    }
}
