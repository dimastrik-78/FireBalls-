using System;
using UISystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StateSystem
{
    public class Win : AGameState
    {
        private GameObject _panelWin;
        
        public Win(GameStateMachine owner, GameObject panelWin) : base(owner)
        {
            _panelWin = panelWin;
        }
        
        public override void Enter(int countPancake)
        {
            Time.timeScale = 0;
            
            _panelWin.SetActive(true);

            Controller.ChangeStateGame += Exit;
            
            Check();
        }
        
        public override void Check()
        {
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
            PlayerPrefs.SetInt("LevelCompleted", PlayerPrefs.GetInt("LevelCompleted") + 1);
        }

        public override void Exit(Type type)
        {
            _panelWin.SetActive(false);
            
            Time.timeScale = 1;
            
            Controller.ChangeStateGame -= Exit;

            SceneManager.LoadScene(0);
        }
    }
}