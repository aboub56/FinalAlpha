using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour
{
    private float timer;
    
    private GameObject player;
    private Health health;
    private WaveSpawner waveSpawner;

    public GameObject seed;
    public Transform seedPos;

    public float currentHealth;
    public int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        waveSpawner = GetComponentInParent<WaveSpawner>();
        player = GameObject.FindGameObjectWithTag("Player");

        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance < 5)
        {
            StartCoroutine(ShootSeedRoutine());
        }
        
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);

            waveSpawner.waves[waveSpawner.currentWaveIndex].enemiesLeft--;
        }
    }

    //void shoot()
    // {

    // }


    IEnumerator ShootSeedRoutine()
    {
        
        Instantiate(seed, seedPos.position, Quaternion.identity);
        yield return new WaitForSeconds(4f);
    }
}
