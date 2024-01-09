using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private List<GameObject> _spawnPoint = new List<GameObject>();
    [SerializeField] private Vector3 _pointDirection;
    private Enemy enemy;
    private float _delay = 2.0f;
    private float _repeatRate = 2.0f;

    private void Start()
    {
        StartCoroutine(nameof(CreateEnemy));
    }

    private void CreateEnemy()
    {
        bool _isActiveSpawner = true;
        int valueSpawnPointCount = _spawnPoint.Count + 1;
        GameObject tempEnemy;

        while (_isActiveSpawner)
        {
            int numberPointSpawn = UnityEngine.Random.Range(0, valueSpawnPointCount);
            tempEnemy = Instantiate(_enemy, _spawnPoint[numberPointSpawn].transform.position, Quaternion.identity);
            tempEnemy.GetComponent<Enemy>().SetDirection(_pointDirection);
        }
    }
}
