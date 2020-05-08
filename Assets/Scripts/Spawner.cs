using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _enemies;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _timeInterval = 2f;
    [SerializeField] private bool _isSpawn = false;

    private DisplayUI _displayUI;

    private void Start()
    {
        _displayUI = gameObject.GetComponent<DisplayUI>();
    }

    private void SpawnEnemy()
    {
        Transform newEnemy = Instantiate(_enemies[Random.Range(0, _enemies.Length)], _spawnPoints[Random.Range(0, _spawnPoints.Length)].localPosition, Quaternion.identity);
        newEnemy.GetComponent<EnemyMovement>().SetTargetPosition(_endPoint);
    }

    private void Update()
    {
        if (_isSpawn)
        {
            if (_timeInterval > 0)
            {
                _timeInterval -= Time.deltaTime;
            }
            else
            {
                SpawnEnemy();
                _timeInterval = 2f;
            }
            _displayUI.SetTime(_timeInterval);
        }
    }
}
