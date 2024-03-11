using GDLib.Comms;
using Mirror;
using UnityEngine;

namespace Space
{
    public class GameManager : MonoBehaviour, IService
    {
        [Header("Bounds")]
        static float maxBoundX = 4.5f;
        public static float MaxBoundX => maxBoundX;
        static float minBoundX = -4.5f;
        public static float MinBoundX => minBoundX;

        static float minBoundY;
        public static float MinBoundY => minBoundY;
        static float maxBoundY;
        public static float MaxBoundY => maxBoundY;

        public void Awake()
        {
            ServiceLocator.AddService(ServiceLibrary.MessageBroker, new MessageBroker());
        }
    }
}
