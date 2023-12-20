using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageControl : MonoBehaviour
{
    public CakeScript cakeScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            cakeScript.UnlitCandle();
        }
    }
}
