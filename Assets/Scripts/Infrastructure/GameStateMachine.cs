using Infrastructure.States;
using Stateless;
using UnityEngine;

namespace Infrastructure
{
    public class GameStateMachine : StateMachine<GlobalState, GlobalAction>
    {
        public GameStateMachine(params IGameState[] states) : base(GlobalState.Bootstrap, FiringMode.Queued)
        {
            foreach (IGameState state in states)
                state.Configure(this);

            this.OnTransitioned(LogTransition);
        }

        private void LogTransition(Transition transition)
        {
            Debug.Log($"Transit state from {transition.Source} to {transition.Destination} on trigger {transition.Trigger}");
        }

        public void Start() =>
            this.Activate();
    }
}