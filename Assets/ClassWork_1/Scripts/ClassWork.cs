using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ClassWork : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefabs;
    private GameObject _instance;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_instance != null)
            {
                Destroy(_instance);
                _instance = null;
            }
            var prefab = _prefabs[Random.Range(0, _prefabs.Count)];
            _instance = Instantiate(prefab, Random.insideUnitSphere *5f, Quaternion.identity);
        }
    }
}
