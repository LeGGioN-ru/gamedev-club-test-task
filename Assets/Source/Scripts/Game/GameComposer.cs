using UnityEngine;
using Zenject;

public class GameComposer : MonoInstaller
{
    [SerializeField] private PlayerSettings _playerSettings;

    public override void InstallBindings()
    {
        Container.BindInstance(new Mover(_playerSettings.Speed)).WhenInjectedInto<PlayerMovePresenter>();
        Container.Bind<Collectable>().FromInstance(new Collectable(5, new Ammo(5)));
        Container.Bind<CollectablePresenter>().AsSingle();
        Container.Bind<Inventory>().FromInstance(new Inventory(5));
        Container.Bind<InventoryPresenter>().AsSingle();
    }
}
