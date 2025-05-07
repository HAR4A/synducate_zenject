using CodeBase.Infrastructure;
using CodeBase.Logic;
using UnityEngine;
using Zenject;

namespace CodeBase.Installers
{
    public class GameRunnerInstaller : MonoInstaller<GameRunnerInstaller>
    {
        [SerializeField] private GameBootstrapper BootstrapperPrefab;
        [SerializeField] private LoadingCurtain CurtainPrefab;
        [SerializeField] private CoroutineRunner coroutineRunnerPrefab;
        public override void InstallBindings()
        {
            // 1) Coroutine runner без циклов
            Container.Bind<ICoroutineRunner>()
                .To<CoroutineRunner>()
                .FromComponentInNewPrefab(coroutineRunnerPrefab)
                .AsSingle()
                .NonLazy();

            // 2) SceneLoader, Curtain
            Container.Bind<SceneLoader>().AsSingle();
            Container.Bind<LoadingCurtain>()
                .FromComponentInNewPrefab(CurtainPrefab)
                .AsSingle();

            // 3) Game & state-machine
            Container.Bind<Game>().AsSingle().NonLazy();

            // 4) Bootstrapper, но без ICoroutineRunner-зависимости
            Container.Bind<GameBootstrapper>()
                .FromComponentInNewPrefab(BootstrapperPrefab)
                .AsSingle()
                .NonLazy();
        }
    }
}