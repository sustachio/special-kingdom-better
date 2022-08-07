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
    [SerializeField] Text highscorePerLevelText;

    private int hasVisited = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = StartTime;

        if (hasVisited == 0)
        {
            hasVisited += 1;
            PlayerPrefs.SetInt("HasVisitedLevel", hasVisited);
            PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, 30.000f);
        }
        if (PlayerPrefs.GetInt("HasVisitedLevel") == 1)
        {
            highscorePerLevelText.text = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        TimerManager();
        if (currentTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        TimeSaver();
    }

    void TimerManager()
    {
        currentTime -= Time.deltaTime;
        currentTime.ToString();
        timerText.text = currentTime.ToString();
    }

    public void TimeSaver()
    {
        StartTime -= currentTime;
        PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name, StartTime);
    }
}