using UnityEngine;

namespace Service
{
    public static class Check
    {
        public static bool Timer(ref float time)
        {
            time -= Time.deltaTime;
            if (time <= 0)
                return true;
            
            return false;
        }
    }
}
