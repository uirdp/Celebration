using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CakeScript : MonoBehaviour
{
    private const int maxHealth = 5;
    private int health;

    public bool isZeroHealth = false;

    [SerializeField] VisualEffect[] CandleLights;
    [SerializeField] GameObject[] CandleFlames;

    private void Start()
    {
        health = 5;
    }
    public void UnlitCandle()
    {
        
        int ind = maxHealth - health;

        Destroy(CandleFlames[ind]);
        --health;
        if (health <= 0) isZeroHealth = true;
    }

    private void SecretCode()
    {
        if (Input.GetKeyDown(KeyCode.M)){
            health++;
        }
    }
}
