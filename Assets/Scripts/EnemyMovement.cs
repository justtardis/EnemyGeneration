using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _targetPosition;
    [SerializeField] private float _speed;
    [SerializeField] private bool _isMove = false;

    private void Start()
    {
        _targetPosition = FindObjectOfType<DeathZone>().gameObject.transform;
    }

    private void Update()
    {
        if (_isMove)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, _targetPosition.localPosition, _speed * Time.deltaTime);
            if (transform.localPosition == _targetPosition.localPosition)
            {
                _isMove = false;
            }
        }
    }
}
