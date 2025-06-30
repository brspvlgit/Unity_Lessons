using System;
using UnityEngine;

namespace HomeWork_1.Scripts
{
    public class PingPong : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Transform _target1;
        [SerializeField] private Transform _target2;

        private bool _isPong;

        private void Update()
        {
            var target = _isPong ? _target1 : _target2;
            if (Vector3.Distance(transform.position, target.position) <= 0.1f)
            {
                _isPong = !_isPong;
            }
            
            var direction = (target.position - transform.position).normalized;
            
            transform.Translate(direction * _speed * Time.deltaTime);
        }
    }
}