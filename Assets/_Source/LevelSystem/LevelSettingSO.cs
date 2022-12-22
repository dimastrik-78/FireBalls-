using System.Collections.Generic;
using ObstacleSystem;
using TargetSystem;
using UnityEngine;

namespace LevelSystem
{
    [CreateAssetMenu(fileName = "LevelSetting", menuName = "LevelSetting")]
    public class LevelSettingSO : ScriptableObject
    {
        [SerializeField] private List<PancakeSO> pancake;
        [SerializeField] private List<int> countPancake;
        [SerializeField] private ObstacleSO obstacle;

        public Dictionary<PancakeSO, int> SpawnPancake;
    }
}
