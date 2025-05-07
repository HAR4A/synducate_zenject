using CodeBase.UI.Services.Factory;
using CodeBase.UI.Services.Windows;
using Zenject;

namespace CodeBase.Installers
{
    public class UIInstaller : MonoInstaller<UIInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IUIFactory>().To<UIFactory>().AsSingle();
            Container.Bind<IWindowService>().To<WindowService>().AsSingle();
        }
    }
}