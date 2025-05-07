using CodeBase.Infrastructure.States;
using CodeBase.Logic;
using Zenject;

namespace CodeBase.Infrastructure
{
  public class Game
  {
    public GameStateMachine StateMachine;

    [Inject]
    public Game(ICoroutineRunner coroutineRunner, LoadingCurtain curtain, SceneLoader sceneLoader, GameStateMachine stateMachine)   
    {
      StateMachine = stateMachine;
    }
  }
}
