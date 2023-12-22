using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;

    public float speed = 10f;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnground = true;
    GunX GunX;
    Health health;

    Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
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
