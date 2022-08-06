using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public FlipOnButtonPress FlipOnButtonPress;
    
    void Start()
    {
        GetComponent<ParticleSystemRenderer>().enabled = (FlipOnButtonPress.facing == -1f);
    }

    void Update()
    {
        GetComponent<ParticleSystemRenderer>().enabled = (FlipOnButtonPress.facing == -1f);
    }
}
