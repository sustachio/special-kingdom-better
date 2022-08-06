using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    private bool playerInZone;

    public string levelToLoad;

    private BoxCollider2D bc2D;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Adding components");
        bc2D = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
        bc2D.size = new Vector2(1f, 1f);
        bc2D.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("GameObject entered: " + gameObject.name + " move into new level");
        SceneManager.LoadScene(levelToLoad);
    }

}
