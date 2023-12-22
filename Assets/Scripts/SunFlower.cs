using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFlower : MonoBehaviour
{
    private float timer;
    private GameObject player;

    public GameObject seed;
    public Transform seedPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance < 5)
        {
            StartCoroutine(ShootSeedRoutine());
        }
        
        //timer -= Time.deltaTime;

        //if (timer < 2)
        //{
        //  timer = 0;
        //Instantiate(seed, seedPos.position, Quaternion.identity);
        //}
    }

    //void shoot()
    // {

    // }


    IEnumerator ShootSeedRoutine()
    {
        yield return new WaitForSeconds(4f);
        Instantiate(seed, seedPos.position, Quaternion.identity);
    }
}
