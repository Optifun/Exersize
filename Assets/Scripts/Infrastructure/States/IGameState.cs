namespace Infrastructure.States
{
    public interface IGameState
    {
        void Configure(GameStateMachine stateMachine);
    }
}