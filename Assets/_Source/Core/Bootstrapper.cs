using System.Collections.Generic;
using GunSystem;
using Interface;
using ObstacleSystem;
using TargetSystem;
using UISystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private List<Pancake> pancake;
        [SerializeField] private List<Obstacle> obstacles;
        [SerializeField] private View status;
        
        void Start()
        {
            for (int i = 0; i < pancake.Count; i++)
            {
                pancake[i].Register(status.Controller);
            }

            for (int i = 0; i < obstacles.Count; i++)
            {
                obstacles[i].Register(status.Controller);
            }
        }

        void Update()
        {
            
        }
    }
}
