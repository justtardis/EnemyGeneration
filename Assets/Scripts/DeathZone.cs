using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private int _damageCount;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            HitDamage(enemy);
        }
    }

    private void HitDamage(Enemy enemy)
    {
        enemy.GetDamage(_damageCount);
    }
}
