using CodeBase.Infrastructure.States;
using CodeBase.Services.Input;
using CodeBase.Services.PersistentProgress;
using CodeBase.Services.Randomizer;
using CodeBase.Services.SaveLoad;
using CodeBase.Services.StaticData;
using UnityEngine;
using Zenject;

namespace CodeBase.Installers
{
    public class ServicesInstaller : MonoInstaller<ServicesInstaller>
    {
        public override void InstallBindings()
        {
            if (Application.isMobilePlatform)
                Container.Bind<IInputService>().To<MobileInputService>().AsSingle();
            else
            {
                Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
            }
            
            Container.Bind<IPersistentProgressService>().To<PersistentProgressService>().AsSingle();
            Container.Bind<IRandomService>().To<RandomService>().AsSingle();
            Container.Bind<ISaveLoadService>().To<SaveLoadService>().AsSingle();
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
            Container.Bind<GameStateMachine>().AsSingle();
    
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsTransient();
            Container.BindInterfacesAndSelfTo<LoadProgressState>().AsTransient();
            Container.BindInterfacesAndSelfTo<LoadLevelState>().AsTransient();
        }
    }
}