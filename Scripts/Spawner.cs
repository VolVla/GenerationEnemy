using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private List<GameObject> _spawnPoint = new List<GameObject>();
    [SerializeField] private Vector3 _pointDirection;
    [SerializeField] private float _coolDown = 2f;
    [SerializeField] private bool _isActiveSpawner = true;

    private void Start()
    {
        StartCoroutine(Create());
    }

    public void CreateEnemy()
    {
        int valueSpawnPointCount = _spawnPoint.Count;
        System.Random random = new System.Random();
        int numberPointSpawn = random.Next(valueSpawnPointCount);
        Instantiate(_enemy, _spawnPoint[numberPointSpawn].transform.position, Quaternion.identity).GetComponent<Enemy>().SetDirection(_pointDirection);
    }

    private IEnumerator Create()
    {
        var waitForSeconds = new WaitForSeconds(_coolDown);

        while (_isActiveSpawner)
        {
            CreateEnemy();

            yield return waitForSeconds;
        }
    }
}
