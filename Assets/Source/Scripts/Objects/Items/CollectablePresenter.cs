using UnityEngine;
using Zenject;

public class CollectablePresenter : MonoBehaviour
{
    private Collectable _collectable;

    public Collectable Collectable => _collectable;

    [Inject]
    public void Construct(Collectable collectable)
    {
        _collectable = collectable;
    }
}
