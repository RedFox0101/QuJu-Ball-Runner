using UnityEngine;
using Zenject;

public class FirstContainerPlayers : MonoInstaller
{
    [SerializeField] private ContainerPlayers _containerPlayers;

    public override void InstallBindings()
    {
        var container = Container.Bind<ContainerPlayers>().FromInstance(_containerPlayers).AsSingle().NonLazy();
        Container.QueueForInject(_containerPlayers);
    }
}