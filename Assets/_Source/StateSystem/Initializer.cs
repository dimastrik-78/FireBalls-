using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StateSystem
{
    public static class Initializer
    {
        public static void GameState(out Dictionary<Type, AGameState> states, GameStateMachine owner,
            GameObject panelWin,
            GameObject panelLose, Text text)
        {
            states = new Dictionary<Type, AGameState>
            {
                { typeof(Play), new Play(owner) },
                { typeof(Win), new Win(owner, panelWin) },
                { typeof(Lose), new Lose(owner, panelLose, text) }
            };
        }
    }
}