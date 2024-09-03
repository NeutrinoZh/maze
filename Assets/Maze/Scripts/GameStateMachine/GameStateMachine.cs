using MTK.StateMachine;

namespace Maze.GSM
{
    public class GameStateMachine : StateMachine
    {
        public GameStateMachine() : base(new()
        {
            [typeof(BootstrapState)] = new BootstrapState()
        })
        {
        }
    }

}