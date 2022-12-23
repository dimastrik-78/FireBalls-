using System;
using TargetSystem;
using UISystem;
using UnityEngine;

namespace StateSystem
{
    public class Play : AGameState
    {
        private int _countPancake;
        private int _countPoint;
        
        public Play(GameStateMachine owner) : base(owner) { }

        private void Setting()
        {
            _countPancake--;

            Check();
        }
        
        private void Setting(int countPoint)
        {
            _countPoint = countPoint;

            Check();
        }

        public override void Enter(int countPancake)
        {
            Time.timeScale = 1;
            
            _countPancake = countPancake;
            
            Pancake.OnDestroy += Setting;
            Controller.Point += Setting;
        }
        
        public override void Check()
        {
            if (_countPancake <= 0)
            {
                Exit(typeof(Win));
            }
            else if (_countPoint < 0)
            {
                Exit(typeof(Lose));
            }
        }

        public override void Exit(Type type)
        {
            Owner.ChangeState(type);
            
            Pancake.OnDestroy -= Setting;
            Controller.Point -= Setting;
        }
    }
}