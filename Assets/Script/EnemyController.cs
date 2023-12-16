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

    virtual protected void WakeUp() { isAwake = true; }

    virtual protected void Activate() { isActivate = true; }
    virtual protected void Deactivate() { isActivate = false; }
    virtual protected void Move() { }


    void Init()
    {
        this.transform.position = cart.transform.position;
        isAwake = false;
    }
}
