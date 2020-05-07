using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _enemies;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _timeInterval = 2f;
    [SerializeField] private bool _isSpawn = false;
    [SerializeField] private Text _timeText;

    private void SpawnPointEnemy()
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
                SpawnPointEnemy();
                _timeInterval = 2f;
            }
            _timeText.text = _timeInterval.ToString("0.###") + " sec";
        }
    }
}
