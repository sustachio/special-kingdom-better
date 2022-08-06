using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] GameObject miniMapDisplay;
    [SerializeField] GameObject miniMapPanel;
    [SerializeField] bool miniMapActive;

    [SerializeField] KeyCode mapDisabler;

    // Start is called before the first frame update
    void Start()
    {
        miniMapDisplay.SetActive(true);
        miniMapActive = true;
        Debug.Log("MiniMap Active");
    }

    void Update()
    {
        if (Input.GetKeyDown(mapDisabler) && miniMapActive == true)
        {
            miniMapDisplay.SetActive(false);
            miniMapActive = false;
            Debug.Log("Minimap inactive");
        }
        if (Input.GetKeyDown(mapDisabler) && miniMapActive == false)
        {
            miniMapDisplay.SetActive(true);
            miniMapActive = true;
            Debug.Log("Map Active");
        }
    }
}
