using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunX : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject projectile2Prefab;
    public Transform firePoint;
    public int currentAmmoK, maxAmmoK = 450;
    public int currentAmmoH, maxAmmoH = 450;
    // Start is called before the first frame update
    void Start()
    {
        currentAmmoH = maxAmmoH; 
        currentAmmoK = maxAmmoK;
    }

    // Update is called once per frame
   


    //Fires stream
    void Update()
    {
        if (Input.GetMouseButton(0) && currentAmmoK > 0)
        {
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            currentAmmoK--;
        }

        if (Input.GetMouseButton(1) && currentAmmoH > 0)
        {
            Instantiate(projectile2Prefab, firePoint.position, firePoint.rotation);
            currentAmmoH--;
        }
    }
}
