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

    private Bloom bloom;
    
    //should be const
    public Color colorForNormal;
    public Color colorForDifficult;
    
    private void ResetGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || cakeScript.isZeroHealth)
        {
            
            SceneManager.LoadScene("forbuild");

            //mos def there is a better way
            VolumeProfile profile = postFX.sharedProfile;
            profile.TryGet<Bloom>(out var bloom);


            if (bloom != null)
            {

                bloom.tint.overrideState = true;

                Debug.Log("you are here");
                bloom.tint.value = colorForNormal;

                
            
            } 
        }
    }

    private void StartDifficultMode()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            
            SceneManager.LoadScene("DifficultMode");

            VolumeProfile profile = postFX.sharedProfile;
            profile.TryGet<Bloom>(out var bloom);


            if (bloom != null)
            {
                bloom.tint.overrideState = true;

                bloom.tint.value = colorForDifficult;
                bloom.active = true;
            }

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
