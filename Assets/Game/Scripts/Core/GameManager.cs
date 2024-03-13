using GDLib.Comms;
using Mirror;
using UnityEngine;

namespace Space
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;

        [Header("Bounds")]
        [SerializeField] float maxBoundX = 2.0f;
        [SerializeField] float minBoundX = -2.0f;
        public float MaxBoundX => maxBoundX;
        public float MinBoundX => minBoundX;

        [SerializeField] float maxBoundY = 5.0f;
        [SerializeField] float minBoundY = -5.0f;
        public float MaxBoundY => maxBoundY;
        public float MinBoundY => minBoundY;

        public void Awake()
        {
            instance = this;
            ServiceLocator.AddService(ServiceLibrary.MessageBroker, new MessageBroker());
        }
    }
}
