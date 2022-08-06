using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    [SerializeField] bool bStartOn = true;
    bool state;

    private void OnEnable()
    {
        EventController.onSwap += SwapState;
    }

    private void OnDisable()
    {
        EventController.onSwap -= SwapState;
    }

    void SetState(bool bState)
    {
        GetComponent<SpriteRenderer>().enabled = bState;
        GetComponent<BoxCollider2D>().enabled = bState;
    }

    void Start()
    {
        state = bStartOn;
        SetState(state);
    }

    void SwapState()
    {
        state = !state;
        SetState(state);
    }
}
