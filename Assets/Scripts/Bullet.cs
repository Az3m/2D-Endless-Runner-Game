using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public float FireCooldown;
    private float NextFireTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextFireTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                NextFireTime = Time.time + FireCooldown;
            }
        }
    }

    void Shoot()//shooting logic
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
