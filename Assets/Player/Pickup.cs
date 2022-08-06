using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public HatController hatController;

    public List<GameObject> hatsList = new List<GameObject>();

    public GameObject[] hats;

    // Start is called before the first frame update
    void Start()
    {
        hatsList.ToArray();
        if (PlayerPrefs.GetInt("HatChoice") == 1)
        {
            Instantiate(hats[PlayerPrefs.GetInt("HatChoice")]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
