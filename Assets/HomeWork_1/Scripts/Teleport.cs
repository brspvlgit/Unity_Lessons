using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace HomeWork_1.Scripts
{
    public class Teleport : MonoBehaviour
    {
        [SerializeField] private float _duration;

        private float _time = 0f;
        
        private void Update()
        {
            _time += Time.deltaTime;

            if (_time > _duration)
            {
                DoTeleport();
                _time = 0;
            }
        }

        private void DoTeleport()
        {
            transform.position += Random.insideUnitSphere * 3f;
        }
    }
}