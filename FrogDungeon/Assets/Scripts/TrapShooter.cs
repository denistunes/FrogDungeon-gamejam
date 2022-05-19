using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapShooter : MonoBehaviour
{
    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            
            Instantiate(projectile, firePoint.position, firePoint.rotation);
            timeBtwShots = startTimeBtwShots;

        } else {

            timeBtwShots -= Time.deltaTime;

        }
    }
}
