using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyZig : EnemyController
{

    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float verticalSpeed = 1.01f;
    

    [SerializeField] private int dir = -1;

    private void ChangeDirection()
    {
        dir = -dir;
        transform.rotation = Quaternion.Euler(0, 0, dir * 60);
        
    }
    protected override void Move()
    {

        transform.position = new Vector3(cart.transform.position.x,
                                         this.transform.position.y + verticalSpeed * dir * Time.deltaTime,
                                         cart.transform.position.z);

        cart.m_Position -= speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "Floor"|| other.gameObject.tag == "Ceilling")
        {
            ChangeDirection();
        }
    }


} 
