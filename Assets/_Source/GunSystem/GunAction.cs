using UnityEngine;

namespace GunSystem
{
    public class GunAction
    {
        public void Shoot(GameObject bullet, Transform spawnPoint)
        {
            Object.Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }
    }
}