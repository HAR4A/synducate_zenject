using Zenject;

namespace CodeBase.Infrastructure.States
{
  public class GameLoopState : IState
  {
    [Inject]
    public GameLoopState(GameStateMachine stateMachine)
    {
    }

    public void Exit()
    {
    }

    public void Enter()
    {
    }
  }
}