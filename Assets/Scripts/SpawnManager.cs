using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameManager gameManagerScript;
    public TextMeshProUGUI waveText;
    public int wave;
    
    public int enemyIndex;
    public float spawnRange;
    public int enemyCount;
    public int enemyCount2;

    public bool CanSpawn = true;
    public int enemyNumber;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<ThornBush>().Length;
        enemyCount2 = FindObjectsOfType<SunFlower>().Length;
        if (enemyCount == 0 && enemyCount2 == 0)
        {
            wave++;
            SpawnEnemyWave(enemyNumber);
            UpdateWave(wave);
        }
    }

    public void UpdateWave(int waveUpOne)
    {
        wave += waveUpOne;
        waveText.text = "Wave: " + wave;
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

    void SpawnLimit ()
    {

    }
}
