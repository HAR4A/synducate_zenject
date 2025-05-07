using CodeBase.Infrastructure.States;
using CodeBase.Logic;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure
{
  public class GameBootstrapper : MonoBehaviour
  {
    [Inject] ICoroutineRunner _runner;
    [Inject] SceneLoader _loader;
    [Inject] LoadingCurtain _curtain;
    [Inject] Game _game;

    void Start()
    {
      // Запуск state machine здесь
      _game.StateMachine.Enter<BootstrapState>();
    }
    
  }
}