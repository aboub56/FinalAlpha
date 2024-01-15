using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private WaveSpawner waveSpawner;

    private Rigidbody enemyRb;
    private PlayerController playerController;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Tells object to follow the players position
        if (player != null)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;

            enemyRb.AddForce(lookDirection * speed);
        }
        
    }
}
