using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Exam_1.Scripts
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Transform _lb;
        [SerializeField] private Transform _rt;
        [SerializeField] private Transform _container;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Spawn();
            }
        }

        private void Spawn()
        {
            var player = Instantiate(_player, _container);

            player.transform.position = new Vector3(
                Random.Range(_lb.position.x, _rt.position.x),
                Random.Range(_lb.position.y, _rt.position.y),
                0);
            
            player.Initialize();
        }
    }
}