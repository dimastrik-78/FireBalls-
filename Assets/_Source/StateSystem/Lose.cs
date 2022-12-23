using System;
using UISystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StateSystem
{
    public class Lose : AGameState
    {
        private GameObject _panelLose;
        private Text _record;
        
        public Lose(GameStateMachine owner, GameObject panelLose, Text record) : base(owner)
        {
            _panelLose = panelLose;
            _record = record;
        }
        
        public override void Enter(int countPancake)
        {
            Time.timeScale = 0;
            
            _panelLose.SetActive(true);

            Check();
            _record.text = $"Record: {PlayerPrefs.GetInt("Record")}";
            
            Controller.ChangeStateGame += Exit;
        }
        
        public override void Check()
        {
            if (!PlayerPrefs.HasKey("Record") 
                || PlayerPrefs.GetInt("Record") < PlayerPrefs.GetInt("LevelCompleted"))
            {
                PlayerPrefs.SetInt("Record", PlayerPrefs.GetInt("LevelCompleted"));
            }
            
            PlayerPrefs.SetInt("Level", 0);
            PlayerPrefs.SetInt("LevelCompleted", 0);
        }

        public override void Exit(Type type)
        {
            _panelLose.SetActive(false);
            
            Time.timeScale = 1;
            
            Controller.ChangeStateGame -= Exit;
            
            SceneManager.LoadScene(0);
        }
    }
}