using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using Cinemachine;

public class EnemyController : MonoBehaviour
{
    public bool isAwake;
    public bool isActivate;
    public float speed;

    public GameObject Player;
    public CinemachineDollyCart cart;
  

    public void WakeUp() { isAwake = true; Debug.Log("Awaken"); }
    
    public void DestroyEnemy() { Destroy(this.gameObject); }
    protected void Activate() { isActivate = true; }
    protected void Deactivate() { isActivate = false; }
    virtual protected void Move() { }


    protected void Init()
    {
        this.transform.position = cart.transform.position;
        isAwake = false;
    }

    private void Awake()
    {
        Init();
    }

    private void Update()
    {
        if (isAwake)
        {
            Move();
        }
    }


}
