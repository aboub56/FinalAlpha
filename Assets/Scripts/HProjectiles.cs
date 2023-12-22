using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HProjectiles : MonoBehaviour
{
    public float speed = 10;
    private GameObject thornBush;
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

    // Projectiles Destroy themselves and heal wild enemies
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.TryGetComponent<Health>(out Health healthComponent))
        {
            healthComponent.TakeDamage(-1);
        }
        Destroy(gameObject);

       // Tells prjectile to damage ThornBush (Undead Enemy)
        if (collision.gameObject.TryGetComponent<ThornBush>(out ThornBush component))
        {
            component.TakeDamage(1);
        }
    }


    IEnumerator DestroyRoutine()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }


}
