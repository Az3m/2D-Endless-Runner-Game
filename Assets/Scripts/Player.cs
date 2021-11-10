using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tutorial I used : https://www.youtube.com/watch?v=U3sT-T5bKX4

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rigid;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(playerDirection.x * playerSpeed, playerDirection.y * playerSpeed);
    }
}
