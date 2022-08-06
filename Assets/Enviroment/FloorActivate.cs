using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorActivate : MonoBehaviour
{
    [SerializeField] GameObject floorOne;
    [SerializeField] GameObject floorTwo;

    float currentTime;
    int startMinutes = 1;

    bool floorOneSelected = true;

    // Start is called before the first frame update
    void Start()
    {
        floorOne.SetActive(true);
        floorTwo.SetActive(false);

        currentTime = startMinutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        selectFloors();
    }

    void selectFloors()
    {
        currentTime = currentTime + Time.deltaTime;

        if (currentTime <= 5 && floorOneSelected == true)
        {
            Debug.Log("Floor One Active");
            floorOne.SetActive(false);
            floorTwo.SetActive(true);
            currentTime = 0;
            floorOneSelected = false;
        }
        if (currentTime <= 5 && floorOneSelected == false)
        {
            Debug.Log("Floor Two Active");
            floorOne.SetActive(true);
            floorTwo.SetActive(false);
            currentTime = 0;
            floorOneSelected = true;
        }
    }
}
