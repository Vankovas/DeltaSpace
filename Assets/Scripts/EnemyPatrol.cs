using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float moveSpeed;
    public bool moveRight;
    private Rigidbody2D rigi;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    private bool atEdge;
    public Transform edgeCheck;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        atEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);
    }

    // Update is called once per frame
    void Update()
    {
        if(hittingWall || atEdge) {
            moveRight = !moveRight;
        }

        if(moveRight) {
            transform.localScale = new Vector3(-1.5f, 1.5f, 1.5f);
            rigi.velocity = new Vector2(moveSpeed, rigi.velocity.y);
        }
        else {
            transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            rigi.velocity = new Vector2(-moveSpeed, rigi.velocity.y);
        }
    }
}
