using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

public class PlayerDamageControl : MonoBehaviour
{
    public CakeScript cakeScript;
    public MMF_Player damageFeedback;

    private void Awake()
    {
        damageFeedback.Initialization();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            damageFeedback?.PlayFeedbacks();
            cakeScript.UnlitCandle();
        }
    }
}
