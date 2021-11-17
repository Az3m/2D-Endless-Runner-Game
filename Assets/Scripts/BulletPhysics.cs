using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    public float Speed = 20f;
    public Rigidbody2D rb;
    private static bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * Speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.tag == "Obstacle")
        {
            Destroy(hitInfo.gameObject);
            Destroy(gameObject);
            hit = true;
        }
       
    }

    public static bool getHit()
    {
        return hit;
    }
    public static void setHit(bool state)
    {
        hit = state;
    }

}
