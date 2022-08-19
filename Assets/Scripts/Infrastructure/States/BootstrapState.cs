using System.Threading.Tasks;

namespace Infrastructure.States
{
    public class BootstrapState : IGameState
    {
        public void Configure(GameStateMachine stateMachine)
        {
            stateMachine.Configure(GlobalState.Bootstrap)
                .Permit(GlobalAction.BootstrapServices, GlobalState.PlayerLoop)
                .OnEntryAsync(Enter)
                .OnExitAsync(Exit);
        }

        private Task Enter()
        {
            throw new System.NotImplementedException();
        }

        private Task Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}