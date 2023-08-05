using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _secondsBetweenSpawn;
    [SerializeField] private Transform[] _spawnPoints;

    private float _pastTime = 0;

    private void Start()
    {
        _pastTime = _secondsBetweenSpawn;
    }
     
    private void Update()
    {
        _pastTime += Time.deltaTime;

        if (_pastTime >= _secondsBetweenSpawn)
        {
            _pastTime = 0;
            Instantiate(_enemyPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length - 1)]);
        }
    }
}
