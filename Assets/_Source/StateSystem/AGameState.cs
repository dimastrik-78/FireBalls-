using System;

namespace StateSystem
{
    public abstract class AGameState
    {
        protected GameStateMachine Owner;
        protected AGameState(GameStateMachine owner)
        {
            Owner = owner;
        }

        public virtual void Enter(int countPancake) {}

        public virtual void Check() {}

        public virtual void Exit(Type type) {}
    }
}