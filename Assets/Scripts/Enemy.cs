using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health { get; private set; }
  
    private void Start()
    {
        Health = 100;
    }

    public void Damage(int getDamage)
    {
        Health -= getDamage;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
