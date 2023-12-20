using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyZig : EnemyController
{

    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float verticalSpeed = 1.01f;
    protected override void Move()
    { 

        transform.position = new Vector3(cart.transform.position.x,
                                         this.transform.position.y + -verticalSpeed * Time.deltaTime,
                                         cart.transform.position.z);

        //this.transform.position.y += verticalSpeed * Time.deltaTime;
        cart.m_Position += speed * Time.deltaTime * Mathf.Sign(transform.forward.x);
    }

   
}
