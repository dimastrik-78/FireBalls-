using System.Collections.Generic;
using LevelSystem;
using StateSystem;
using UISystem;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private List<LevelSettingSO> settingLevel;
        [SerializeField] private View status;
        [SerializeField] private GameObject panelWin;
        [SerializeField] private GameObject panelLose;
        [SerializeField] private Text text;

        private GameStateMachine _gameStateMachine;
        private LevelSetting _levelSetting = new();
        
        void Start()
        {
            Check();

            _levelSetting.Start(spawnPoint, settingLevel, status);

            _gameStateMachine = new GameStateMachine(_levelSetting.CountPancake, panelWin, panelLose, text);
            _gameStateMachine.ChangeState(typeof(Play));
        }

        private void Check()
        {
            if (!PlayerPrefs.HasKey("Level"))
            {
                PlayerPrefs.SetInt("Level", 0);
            }
            
            if (!PlayerPrefs.HasKey("LevelCompleted"))
            {
                PlayerPrefs.SetInt("LevelCompleted", 0);
            }
        }
    }
}
