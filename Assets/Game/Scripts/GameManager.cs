using GDLib.Comms;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Space
{
    public class GameManager : MonoBehaviour, IService
    {
        [Header("Bounds")]
        [SerializeField] float maxBoundX;
        public float MaxBoundX => maxBoundX;
        [SerializeField] float minBoundX;
        public float MinBoundX => minBoundX;

        [SerializeField] float minBoundY;
        public float MinBoundY => minBoundY;
        [SerializeField] float maxBoundY;
        public float MaxBoundY => maxBoundY;

        public void Awake()
        {
            ServiceLocator.AddService("gameManager", this);
            ServiceLocator.AddService("messageBroker", new MessageBroker());
        }
    }
}
