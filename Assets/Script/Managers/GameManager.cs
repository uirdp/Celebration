using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public CakeScript cakeScript;
    public Volume postFX;

    public GameEvent startNormalMode;
    public GameEvent startDifficultMode;

    private Bloom bloom;
    
    //should be const
    public Color colorForNormal;
    public Color colorForDifficult;
    
    //TODO -> making the them the same scene
    private void ResetGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || cakeScript.isZeroHealth)
        {
            
            SceneManager.LoadScene("forbuild");

           startNormalMode.Raise();
        }
    }

    private void StartDifficultMode()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            
            SceneManager.LoadScene("DifficultMode");

            startDifficultMode.Raise();

        }
    }

    private void QuitGame()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    void Update()
    {
        ResetGame();
        StartDifficultMode();
        QuitGame();
    }

}
