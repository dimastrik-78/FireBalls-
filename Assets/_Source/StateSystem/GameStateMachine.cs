using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StateSystem
{
    public class GameStateMachine
    {
        private Dictionary<Type, AGameState> _states;
        private AGameState _currentGameState;
        private int _countPancake;
        
        public GameStateMachine(int countPancake, GameObject panelWin, GameObject panelLose, Text text)
        {
            _countPancake = countPancake;
            
            Initializer.GameState(out _states, this, panelWin, panelLose, text);
        }

        public void ChangeState(Type type)
        {
            _currentGameState = _states[type];
            _currentGameState.Enter(_countPancake);
        }
    }
}