using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
using UnityEngine.VFX;

//should be renamed to status control
public class PlayerStatusControl : MonoBehaviour
{
    public CakeScript cakeScript;

    public VisualEffect firework;
    public MMF_Player damageFeedback;

    public GameEvent goalEvent;

    private bool isInvincible;
    
    //these are called from Animation Event
    private void GiveInvincibility()
    {
        isInvincible = true;
    }

    private void TakeInvincibility()
    {
        isInvincible = false;
    }

    private void OnPlayerReachGoal()
    {
        goalEvent.Raise();
    }

    private void Awake()
    {
        damageFeedback.Initialization();
        firework.SendEvent("Stop");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (!isInvincible)
            {
                damageFeedback?.PlayFeedbacks();
                cakeScript.UnlitCandle();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goal")
        {
            firework.SendEvent("Play");

            OnPlayerReachGoal();
        }
    }
}
