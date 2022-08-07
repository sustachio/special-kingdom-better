using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectLoader : MonoBehaviour
{
    Button levelButton;
    [SerializeField] string keyPadNum;
    [SerializeField] TMPro.TMP_Text putNumberText;

    int q = 1;

    // Start is called before the first frame update
    void Start()
    {
        levelButton = gameObject.GetComponent<Button>();
        levelButton.onClick.AddListener(ExecuteNewLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExecuteNewLevel()
    {
        putNumberText.enabled = false;
        Debug.Log("Loading new level");
        SceneManager.LoadScene(keyPadNum);
    }
}
