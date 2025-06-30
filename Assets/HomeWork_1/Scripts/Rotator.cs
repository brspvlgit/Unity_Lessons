using System;
using UnityEngine;

namespace HomeWork_1.Scripts
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed = 100f;

        private void Update()
        {
            transform.Rotate(Vector3.forward, _rotationSpeed * Time.deltaTime);
        }
    }
}