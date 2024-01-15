using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    

    public float speed = 10f;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnground = true;

    public int maxHealth;
    public float currentHealth;


    private bool isDead;
    
    public GameManager gameManager;
    
    GunX GunX;
    Health health;

    Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        float forwardInput = Input.GetAxis("Horizontal");
        if (forwardInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.right * forwardInput * Time.deltaTime * speed);
        }

        if (forwardInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.left * forwardInput * Time.deltaTime * speed);

        }

         

        if(Input.GetKey(KeyCode.W))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }


        if (transform.position.y > 34)
        {
            transform.position = new Vector3(transform.position.x, 34, transform.position.z);
        }
    }


    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0 && !isDead)
        {
            isDead = true;
            gameManager.GameOver();
            Destroy(gameObject);
            
        }
    }

    private void gameEnd()
    {
        //if (gameObject == null)
        {
            //gameManager.GameOver();
            //Debug.Log("Game Over");
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnground = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        
        
        
        if (other.CompareTag("KRefill") || other.CompareTag("HRefill"))
        {
            Destroy(other.gameObject);
        }
    }
}
