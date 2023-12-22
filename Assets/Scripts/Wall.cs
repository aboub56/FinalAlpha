using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float health;
    public int maxHealth = 3;

    // Start is called before the first frame update
    public void Start()
    {
        health = maxHealth;
    }


    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
