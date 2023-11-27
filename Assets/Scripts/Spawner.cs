using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _secondsBetweenSpawn;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }
     
    private IEnumerator EnemySpawn()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_secondsBetweenSpawn);

        while (true)
        {
            Instantiate(_prefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)]);
            yield return waitForSeconds;
        }
    }
}
