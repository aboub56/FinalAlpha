using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed = 10;
    private Health health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        StartCoroutine(DestroyRoutine());
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.TryGetComponent<SunFlower>(out SunFlower sunflowerComponent))
        {
            sunflowerComponent.TakeDamage(1);
        }
        Destroy(gameObject);
    }


    IEnumerator DestroyRoutine()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
