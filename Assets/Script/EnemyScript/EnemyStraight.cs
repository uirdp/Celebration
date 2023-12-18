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
        Debug.Log("Move Called");

        transform.position = cart.transform.position;
        cart.m_Position += speed * Time.deltaTime * Mathf.Sign(transform.forward.x);
    }

   
}
