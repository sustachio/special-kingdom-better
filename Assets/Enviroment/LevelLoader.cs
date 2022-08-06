using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{

    public bool playerInZone;

    public string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInZone)
        {
            Application.LoadLevel(levelToLoad);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            playerInZone = true;
        }
        if (other.name == "PlayerBody")
        {
            playerInZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            playerInZone = false;
        }

        if (other.name == "Player 1")
        {
            playerInZone = false;
        }
    }

}
