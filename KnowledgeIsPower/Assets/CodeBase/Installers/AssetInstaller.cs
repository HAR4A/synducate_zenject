using CodeBase.Infrastructure.AssetManagement;
using Zenject;

namespace CodeBase.Installers
{
    public class AssetInstaller : MonoInstaller<AssetInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
        }
    }
}