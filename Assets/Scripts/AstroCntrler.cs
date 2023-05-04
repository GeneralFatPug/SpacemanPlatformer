using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroCntrler : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
    private float jumpForce;
    private float moveHorizontal;
    private float moveVertical;

    // Start is called before the first frame update
    void Start()
    {//runs once
        rb2D = GetComponent<Rigidbody2D>();

        moveSpeed = 3f;
        jumpForce = 8f;
    }

    // Update is called once per frame
    void Update()
    { //constantly running without physics engine
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.Space)){
            rb2D.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb2D.velocity = new Vector2(moveHorizontal*moveSpeed, rb2D.velocity.y);

        rb2D.drag = 1f;
        rb2D.gravityScale = 1f;
    }
}
