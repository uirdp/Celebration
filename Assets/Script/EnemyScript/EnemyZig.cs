using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class EnemyZig : EnemyController
{

    private void ChangeDirection()
    {
        enemData.dir = -enemData.dir;
        transform.rotation = Quaternion.Euler(0, 0, enemData.dir * 60);
        
    }
    protected override void Move()
    {

        transform.position = new Vector3(cart.transform.position.x,
                                         this.transform.position.y + enemData.verticalSpeed * enemData.dir * Time.deltaTime,
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
