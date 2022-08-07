using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] GameObject miniMapDisplay;
    public GameObject miniMapPanel;
    [SerializeField] int miniMapInt;

    [SerializeField] KeyCode mapDisabler;

    // Start is called before the first frame update
    void Start()
    {
        miniMapDisplay.SetActive(true);
        miniMapInt += 1;
        Debug.Log("MiniMap Active");
    }

    void Update()
    {
        if (Input.GetKeyDown(mapDisabler) && miniMapInt == 1)
        {
            miniMapDisplay.SetActive(false);
            miniMapPanel.SetActive(false);
            miniMapInt += 1;
            Debug.Log("Minimap inactive");
        }
        else if (Input.GetKeyDown(mapDisabler) && miniMapInt == 2)
        {
            miniMapDisplay.SetActive(true);
            miniMapPanel.SetActive(true);
            miniMapInt -= 1;
            Debug.Log("Map Active");
        }
    }
}
