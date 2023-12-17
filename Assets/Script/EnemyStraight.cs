using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyStraight : EnemyController
{
    public CinemachineDollyCart cart;

    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float acc;
    protected override void Move()
    {
        transform.position = cart.transform.position;
        cart.m_Position += speed * Time.deltaTime * Mathf.Sign(transform.forward.x);
    }
}
