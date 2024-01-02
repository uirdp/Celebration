using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using Cinemachine;

public class EnemyController : MonoBehaviour
{
    public bool isAwake;
    public bool isActivate;

    //public GameObject Player;
    public CinemachineDollyCart cart;
    public EnemyData enemData;

    public float speed;
  

    public void WakeUp() { isAwake = true; }
    
    public void DestroyEnemy() { Destroy(this.gameObject); }
    protected void Activate() { isActivate = true; }
    protected void Deactivate() { isActivate = false; }
    virtual protected void Move() { }


    protected void Init()
    {
        speed = enemData.speed;
        this.transform.position = new Vector3(cart.transform.position.x,
                                              this.transform.position.y,
                                              cart.transform.position.z);
        isAwake = false;
    }

    private void Start()
    {
        Init();
    }

    protected virtual void Update()
    {
        if (isAwake)
        {
            Move();
        }
    }

}
