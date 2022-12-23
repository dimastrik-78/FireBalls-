using System.Collections.Generic;
using ObstacleSystem;
using TargetSystem;
using UISystem;
using UnityEngine;
using Object = UnityEngine.Object;

namespace LevelSystem
{
    public class LevelSetting
    {
        public int CountPancake;

        private void Check(List<LevelSettingSO> settingLevel)
        {
            if (PlayerPrefs.GetInt("Level") >= settingLevel.Count)
            {
                PlayerPrefs.SetInt("Level", 0);
            }
        }
        
        public void Start(Transform spawnPoint, List<LevelSettingSO> settingLevel, View status)
        {
            Check(settingLevel);
            
            var position = spawnPoint.position;
            for (int j = 0; j < settingLevel[PlayerPrefs.GetInt("Level")].Pancake.Count; j++)
            {
                for (int k = 0; k < settingLevel[PlayerPrefs.GetInt("Level")].CountPancake[j]; k++)
                {
                    Object.Instantiate(settingLevel[PlayerPrefs.GetInt("Level")].Pancake[j].PrefabPancake,
                        new Vector3(position.x, position.y + k, position.z),
                        Quaternion.identity).GetComponent<Pancake>().Register(status.Controller);
                    CountPancake++;
                }

                Object.Instantiate(settingLevel[PlayerPrefs.GetInt("Level")].Obstacle.PrefabPancake,
                    new Vector3(position.x, position.y, position.z + 10),
                    Quaternion.identity).GetComponent<Obstacle>().Register(status.Controller);
            }
        }
    }
}
