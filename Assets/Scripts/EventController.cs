using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    public delegate void SwapAction();
    public static event SwapAction onSwap;

    // time to call swap
    [SerializeField] float fChangeTime = 5;
    float time = 0f;

    void Update()
    {
        time += Time.deltaTime;
        // call swap event
        if (fChangeTime <= time)
        {
            time = 0f;
            if (onSwap != null)
                onSwap();
        }
    }
}
