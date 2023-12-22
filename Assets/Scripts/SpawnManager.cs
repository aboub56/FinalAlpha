using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    public float spawnRange;
    public int enemyCount;
    public int enemyCount2;
    private int waveNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<ThornBush>().Length;
        enemyCount2 = FindObjectsOfType<SunFlower>().Length;
        if (enemyCount == 0 && enemyCount2 == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }

    void SpawnEnemyWave(int enemiestoSpawn)
    {
        for (int i = 0; i < enemiestoSpawn; i++)
        {
            int enemyIndex = Random.RandomRange(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], GenerateSpawnPosition(), enemyPrefabs[enemyIndex].transform.rotation);
        }
    }


    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(0, spawnRange);
        float spawnPosY = Random.Range(1, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);

        return randomPos;
    }
}
