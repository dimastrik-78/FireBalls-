using System.Collections.Generic;
using ObstacleSystem;
using TargetSystem;
using UnityEngine;

namespace Core
{
    public class SettingLevel : MonoBehaviour
    {
        [SerializeField] private List<PancakeSO> pancakeSO;
        [SerializeField] private List<int> pancakeCount;
        [SerializeField] private ObstacleSO obstacleSo;

        private Dictionary<PancakeSO, int> _dictionary;
        void Start()
        {
            for (int i = 0; i < pancakeSO.Count; i++)
            {
                _dictionary.Add(pancakeSO[i], pancakeCount[i]);
            }
        }

        void Update()
        {
            
        }
    }
}
