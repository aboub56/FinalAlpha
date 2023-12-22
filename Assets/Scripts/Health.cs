using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private GameManager gameManager;
    public int maxHealth;
    public float currentHealth;
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

        if (currentHealth <= 0 && gameObject.CompareTag("Player"))
        {
            
            gameManager.gameOver();
            Destroy(gameObject);
        }
    }
}
