using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public string dangerousTag;
    public Vector3 startPos;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == dangerousTag)
        {
            transform.position = startPos;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
