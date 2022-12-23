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

        public List<PancakeSO> Pancake => pancake;
        public List<int> CountPancake => countPancake;
        public ObstacleSO Obstacle => obstacle;
    }
}
