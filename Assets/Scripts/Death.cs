using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject car;
    [SerializeField] GameObject lightning;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Road"))
        {
            Instantiate(car, new Vector3(transform.position.x - 25, transform.position.y+4, 0), Quaternion.identity);
        } 
        else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Cloud"))
        {
            Instantiate(lightning, new Vector3(transform.position.x-25, transform.position.y, 0), Quaternion.identity);
        }
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Car"))
        {
            Time.timeScale = 0;
        }
    }
}
