using GunSystem;
using Interface;
using UISystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private ListenerInput listenerInput;
        [SerializeField] private Status status;
        
        void Start()
        {
            listenerInput.Register(status);
            listenerInput.Notify();
        }

        void Update()
        {
            
        }
    }
}
