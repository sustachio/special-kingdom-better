using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatController : MonoBehaviour
{
    [SerializeField] CircleCollider2D cc2D;

    public Pickup pickup;

    // Start is called before the first frame update
    void Start()
    {
        cc2D.isTrigger = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Player picked up hat");
            if (gameObject.name == "RedHat")
            {
                pickup.hatsList.Add(gameObject);
                PlayerPrefs.SetInt("HatChoice", 1);
            }
        }
        else
        {
            Debug.Log("Not player");
        }
    }
}
