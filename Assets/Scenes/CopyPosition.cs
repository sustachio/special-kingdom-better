using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;

    // make certian changes optional
    [SerializeField]
    bool x;
    [SerializeField]
    bool y;
    [SerializeField]
    bool z;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (
            x? transTarget.position.x: transform.position.x,
            y? transTarget.position.y: transform.position.y,
            z? transTarget.position.z: transform.position.z
        );
    }
}
