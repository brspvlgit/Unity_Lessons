using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Exam_1.Scripts
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _impulse;
        [SerializeField] private List<Material> _materials;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private List<MeshRenderer> _meshRenderer;
        
        private Vector3 _velocity;
        
        public void Initialize()
        {
            Change();
            
            _velocity = Random.onUnitSphere.normalized * _impulse;
        }

        private void Change()
        {
            var material = _materials[Random.Range(0, _materials.Count)];
            foreach (var renderer in _meshRenderer)
            {
                renderer.material = material;
                renderer.enabled = false;
            }
            _meshRenderer[Random.Range(0, _meshRenderer.Count)].enabled = true;
            
            transform.localScale = Vector3.one * Random.Range(0.8f, 1.75f);
        }

        private void FixedUpdate()
        {
            _rigidbody.position += _velocity * Time.fixedDeltaTime;
        }

        private void OnCollisionEnter(Collision other)
        {
            var contact = other.contacts[0];
            
            var normal = contact.normal;
            
            var newDirection = Vector3.Reflect(_velocity.normalized, normal);
            _velocity = newDirection * _velocity.magnitude;
            
            Change();
        }
    }
}