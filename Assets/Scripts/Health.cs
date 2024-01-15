using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    
    public int maxHealth;
    public float currentHealth;

    public GameManager gamerManager;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Positive Health value
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            
        }
    }
}
