using CodeBase.Infrastructure.Factory;
using Zenject;

namespace CodeBase.Installers
{
    public class FactoryInstaller : MonoInstaller<FactoryInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IGameFactory>().To<GameFactory>().AsSingle();
        }
    }
}