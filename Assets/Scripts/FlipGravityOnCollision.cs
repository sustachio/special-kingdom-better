using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipGravityOnCollision : MonoBehaviour
{
    bool normalGravity = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            normalGravity = !normalGravity;
            Debug.Log("top collided");
            Physics.gravity = new Vector3(0, 9.8f, 0);
        }
    }
}
