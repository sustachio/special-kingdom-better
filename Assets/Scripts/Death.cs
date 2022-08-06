using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject car;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Road"))
        {
            Instantiate(car, new Vector3(-25, -3, 0), Quaternion.identity);
        }
        else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Car"))
        {
            Time.timeScale = 0;
        }
    }
}
