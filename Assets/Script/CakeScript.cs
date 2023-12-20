using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CakeScript : MonoBehaviour
{
    private const int maxHealth = 5;
    private int health;

    [SerializeField] VisualEffect[] CandleLights;
    [SerializeField] GameObject[] CandleFlames;

    private void Start()
    {
        health = 5;
    }
    public void UnlitCandle()
    {
        int ind = maxHealth - health;
        if (ind > 5) return;

        Destroy(CandleFlames[ind]);
        --health;
    }
}
