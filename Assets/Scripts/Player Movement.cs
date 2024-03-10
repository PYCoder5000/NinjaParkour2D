using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpPower;
    public float distCanJump;
    int jumpTime;
    bool canJump;
    private void Update()
    {
        float InputX = Input.GetAxis("Horizontal");
        float Movement = InputX * speed * Time.deltaTime;
        RaycastHit2D hit = Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y-(float)1.1, transform.position.z), -transform.up, distCanJump);
        if (hit.transform != null)
        {
            canJump = true;
            jumpTime = 0;
        }
        else
        {
            canJump = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && (canJump || jumpTime < 1))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb.velocity.y < 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
            }
            rb.AddForce(transform.up*jumpPower, ForceMode2D.Impulse);
            jumpTime += 1;
        }
        Vector3 TranslationVector = new Vector3(Movement, 0, 0);
        transform.Translate(TranslationVector);
    }
}
