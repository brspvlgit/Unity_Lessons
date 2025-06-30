using UnityEngine;

namespace HomeWork_1.Scripts
{
    public class Scaler : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Vector3 _target1;
        [SerializeField] private Vector3 _target2;

        private bool _isPong;

        private void Update()
        {
            var target = _isPong ? _target1 : _target2;
            if (Vector3.Distance(transform.localScale, target) <= 0.01f)
            {
                _isPong = !_isPong;
            }
            
            var direction = (target - transform.localScale).normalized;
            
            transform.localScale += direction * _speed * Time.deltaTime;
        }
    }
}