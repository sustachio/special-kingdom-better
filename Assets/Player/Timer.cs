using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float StartTime;
    float currentTime;
    [SerializeField] Text timerText;
    [SerializeField] GameObject DeathSquare;
    Vector2 playerPosition;

    private int hasVisited = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = StartTime;
        playerPosition = gameObject.transform.position;

        if (hasVisited == 0)
        {
            hasVisited += 1;
            PlayerPrefs.SetInt("HasVisitedLevel", hasVisited);
            PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, 30.000f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = gameObject.transform.position;
        TimerManager();
        if (currentTime <= 0)
        {
            Instantiate(DeathSquare, playerPosition, Quaternion.identity);
            Time.timeScale = 0;
        }
    }

    void OnDestroy()
    {
        TimeSaver();
    }

    void TimerManager()
    {
        currentTime -= Time.deltaTime;
        timerText.text = (Mathf.Round(currentTime * 10) / 10).ToString();
    }

    public void TimeSaver()
    {
        StartTime -= currentTime;
        PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, StartTime);
    }
}