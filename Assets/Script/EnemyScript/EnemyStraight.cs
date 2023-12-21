using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyStraight : EnemyController
{

    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float acc = 1.001f;
    protected override void Move()
    {
        speed *= acc;

        transform.position = new Vector3(cart.transform.position.x,
                                         this.transform.position.y,
                                         cart.transform.position.z);
        cart.m_Position += speed * Time.deltaTime * -1;
    }

   
}
