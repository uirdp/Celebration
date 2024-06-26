﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.Runtime.InteropServices;
using UnityEngine.UIElements;

public class PlayerController_Platform : MonoBehaviour
{
    //static Quaternion rev = Quaternion.Euler(0, 180, 0);
    //public CinemachinePath path;
    public CinemachineDollyCart cart;

    private Animator anim;

    [Header("Rotation speed")]
    public float speed_rot;

    [Header("Movement speed during jump")]
    public float speed_move;

    [Header("Time available for combo")]
    public int term;

    public bool isJump;
    //public bool isMidAir; //isJumpの仕様がわからんのでフラグを追加
    public bool isDoubleJump;
    public bool isDodge;

    private bool isOnGround;
    public float rayCastOffset;

    private Vector3 forward;
    private void Awake()
    {
        
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
        forward = transform.forward;
    }

    private void Update()
    {

        transform.position = new Vector3(cart.transform.position.x, transform.position.y, cart.transform.position.z);

        isOnGround = Physics.Raycast(transform.position, Vector3.down, rayCastOffset);

        Rotate();
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isJump && !isDoubleJump) { DoubleJump(); }
        }

        if (!isJump)
        {
            Jump();

            Attack();
            
            Dodge();

            Block();

            Crouch();

            Skill1();
            
            Skill2();
            
            Skill3();
            
            Skill4();
            
            Skill5();
            
            Skill6();
            
            Skill7();
            
            Skill8();
        }

        
    }

    Quaternion rot;
    bool isRun;
    
    void Rotate()
    {
        Vector3 rotateAixs = cart.transform.rotation.eulerAngles;
        float axis = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.D))
        {            
            Move();            
            rot = Quaternion.Euler(0, rotateAixs.y, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, speed_rot * Time.deltaTime);
        }

        
        else if (Input.GetKey(KeyCode.A))
        {
            Move();
            rot = Quaternion.Euler(0, -rotateAixs.y, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, speed_rot * Time.deltaTime);
        }

        else
        {            
            anim.SetBool("Run", false);
            anim.SetBool("Walk", false);
        }


    }

    
    void Move()
    {
        if (isJump || isDoubleJump)
        {                       
            anim.SetBool("Run", false);
            anim.SetBool("Walk", false);
            transform.position = new Vector3(cart.transform.position.x, 
                                             transform.position.y, 
                                             cart.transform.position.z);

        }
        else
        {            
            anim.SetBool("Run", true);
            anim.SetBool("Walk", Input.GetKey(KeyCode.LeftShift));
            transform.position = new Vector3(cart.transform.position.x,
                                             transform.position.y,
                                             cart.transform.position.z);

            if(!isOnGround) transform.Translate(Vector3.down * Time.deltaTime);
        }
        cart.m_Position += speed_move * Time.deltaTime * -Mathf.Sign(transform.forward.x);
    }

    int clickCount;
    float timer;
    bool isTimer;

    
    void Attack()
    {
        
        if (isTimer)
        {
            timer += Time.deltaTime;
        }

        
        if (Input.GetMouseButtonDown(0))
        {
            switch (clickCount)
            {
                
                case 0:
                    
                    anim.SetTrigger("Attack1");
                    
                    isTimer = true;
                    
                    clickCount++;
                    break;

                
                case 1:
                    
                    if (timer <= term)
                    {                        
                        anim.SetTrigger("Attack2");
                        
                        clickCount++;
                    }

                    
                    else
                    {                        
                        anim.SetTrigger("Attack1");
                        
                        clickCount = 1;
                    }

                    
                    timer = 0;
                    break;

                
                case 2:
                    
                    if (timer <= term)
                    {                        
                        anim.SetTrigger("Attack3");
                        
                        clickCount = 0;
                        
                        isTimer = false;
                    }

                    
                    else
                    {                        
                        anim.SetTrigger("Attack1");
                        
                        clickCount = 1;
                    }
                
                    timer = 0;
                    break;
            }
        }
    }

    
    void Dodge()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && !isDodge)
        {            
            anim.SetTrigger("Dodge");
            isDodge = true;
        }
    }

    private void DodgeEnd()
    {
        Debug.Log("here");
        isDodge = false;
    }

    void Block()
    {
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("Block", true);
        }
        if (Input.GetMouseButtonUp(1))
        {
            anim.SetBool("Block", false);
        }
    }

    void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Crouch", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Crouch", false);
        }
    }


    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {            
            anim.SetBool("Block", false);
            anim.SetBool("Crouch", false);
            
            anim.SetTrigger("Jump");
            isJump = true;

        }
    }

    void DoubleJump()
    {
       
            anim.SetBool("Block", false);
            anim.SetBool("Crouch", false);

            anim.SetTrigger("DoubleJump");
            isDoubleJump = true;

    }

    void JumpEnd()
    {
        isJump = false;
        isDoubleJump = false;
    }

    // Skill1
    void Skill1()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Play Skill1 animation
            anim.SetTrigger("Skill1");
        }
    }
    // Skill2
    void Skill2()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Play Skill2 animation
            anim.SetTrigger("Skill2");
        }
    }
    // Skill3
    void Skill3()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Play Skill3 animation
            anim.SetTrigger("Skill3");
        }
    }
    // Skill4
    void Skill4()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // Play Skill4 animation
            anim.SetTrigger("Skill4");
        }
    }
    // Skill5
    void Skill5()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // Play Skill5 animation
            anim.SetTrigger("Skill5");
        }
    }
    // Skill6
    void Skill6()
    {
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // Play Skill6 animation
            anim.SetTrigger("Skill6");
        }
    }
    // Skill7
    void Skill7()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // Play Skill7 animation
            anim.SetTrigger("Skill7");
        }
    }
    // Skill8
    void Skill8()
    {
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            // Play Skill8 animation
            anim.SetTrigger("Skill8");
        }
    }

}
