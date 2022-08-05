using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipGravityOnCollision : MonoBehaviour
{
    bool normalGravity = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("b");
        if (collision.gameObject.layer == 6)
        {
            normalGravity = !normalGravity;
            Debug.Log("a");
            Physics.gravity = new Vector3(0, normalGravity?-9.8f:-9.8f, 0);
        }
    }
}
