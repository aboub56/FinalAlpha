using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeed : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2 (direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.x, -direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, rot, 0);

        StartCoroutine(DestroyRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.TryGetComponent<Health>(out Health healthComponent))
        {
            healthComponent.TakeDamage(1);
        }
        Destroy(gameObject);
    }

    IEnumerator DestroyRoutine()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
