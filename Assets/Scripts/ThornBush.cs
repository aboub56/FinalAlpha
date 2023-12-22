using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornBush : MonoBehaviour
{
    private Health health;
    public int maxHealth;
    public float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    //Negative Health value (Zombie Plants)
   public void TakeDamage(float damageAmount)
    {
        currentHealth += damageAmount;

        if (currentHealth >= 0)
        {
            Destroy(gameObject);
        }
    }


    // Deals Damage when in contact with the player
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Health>(out Health healthComponent))
        {
    }
        healthComponent.TakeDamage(3);
        }
}
