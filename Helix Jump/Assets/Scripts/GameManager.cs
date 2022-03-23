using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject FailureScreen;
    public GameObject VictoryScreen;
    

    // Start is called before the first frame update
    void Start()
    {
        CloseFailureScreen();
        CloseVictoryScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowVictoryScreen()
    {
        VictoryScreen.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void CloseVictoryScreen()
    {
        VictoryScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void ShowFailureScreen()
    {
        FailureScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseFailureScreen()
    {
        FailureScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CloseFailureScreen();
        CloseVictoryScreen();
    }

    

}
