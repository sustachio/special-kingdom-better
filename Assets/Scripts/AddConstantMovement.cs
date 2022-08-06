using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantMovement : MonoBehaviour
{
    [SerializeField] Vector2 Force;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x+Force.x*Time.deltaTime, transform.position.y+Force.y*Time.deltaTime);
    }
}
