using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
using UnityEngine.VFX;

//should be renamed to status control
public class PlayerDamageControl : MonoBehaviour
{
    public CakeScript cakeScript;
    public VisualEffect firework;
    public MMF_Player damageFeedback;

    private void Awake()
    {
        damageFeedback.Initialization();
        firework.SendEvent("Stop");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            damageFeedback?.PlayFeedbacks();
            cakeScript.UnlitCandle();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goal")
        {
            Debug.Log("fire");
            firework.SendEvent("Play");
        }
    }
}
