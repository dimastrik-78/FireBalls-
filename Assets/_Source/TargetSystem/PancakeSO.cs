using UnityEngine;

namespace TargetSystem
{
    [CreateAssetMenu(fileName = "Pancake", menuName = "Pancake")]
    public class PancakeSO : ScriptableObject
    {
        [SerializeField] private GameObject prefabPancake;
        [SerializeField] private int givesPoints;

        public GameObject PrefabPancake => prefabPancake;
        public int GivesPoints => givesPoints;
    }
}
