using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CakeScript : MonoBehaviour
{
    private const int maxHealth = 5;
    private int health;

    [SerializeField] VisualEffect[] CandleLights;


    private void Start()
    {
        health = 5;
    }
    void UnlitCandle()
    {
        int ind = maxHealth - health;
        if (ind < 0) return;

        CandleLights[ind].SendEvent("StopPlay");
    }
}
