using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;

    public void GetDamage(int damageCount)
    {
        _health -= damageCount;
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
