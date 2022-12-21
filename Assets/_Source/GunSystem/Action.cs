using Interface;
using UnityEngine;

namespace GunSystem
{
    public class Action
    {
        public void Shoot(GameObject bullet, Transform spawnPoint)
        {
            Object.Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }
    }
}