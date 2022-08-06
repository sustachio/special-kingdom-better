using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGloomy : MonoBehaviour
{
    public FlipOnButtonPress FlipOnButtonPress;

    void Start()
    {
        if (FlipOnButtonPress.facing == 1f)
            GetComponent<Camera>().backgroundColor = new Color(49f / 255f, 77f / 255f, 121f / 255f, 1f);
        else
            GetComponent<Camera>().backgroundColor = new Color(0, 0, 0, 1f);
    }

    void Update()
    {
        if (FlipOnButtonPress.facing == 1f)
            GetComponent<Camera>().backgroundColor = new Color(49f / 255f, 77f / 255f, 121f / 255f, 1f);
        else
            GetComponent<Camera>().backgroundColor = new Color(0, 0, 0, 1f);
    }
}
