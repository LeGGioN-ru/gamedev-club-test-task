using UnityEngine;
using Zenject;

public class InventoryPresenter : MonoBehaviour
{
    private Inventory _inventory;

    [Inject]
    public void Construct(Inventory inventory)
    {
        _inventory = inventory;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out CollectablePresenter collectablePresenter))
            if (_inventory.TryAddItem(collectablePresenter.Collectable))
                Destroy(collision.gameObject);
    }
}
