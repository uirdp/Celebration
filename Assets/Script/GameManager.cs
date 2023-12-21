using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public CakeScript cakeScript;
    private void ResetGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || cakeScript.isZeroHealth)
        {
            SceneManager.LoadScene("forbuild");
        }
    }
}
