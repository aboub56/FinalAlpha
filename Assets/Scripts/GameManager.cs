using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    
    public SpawnManager spawnManager;
    
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
    }

 


    public void gameOver()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
