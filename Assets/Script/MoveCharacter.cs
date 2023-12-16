using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    static int hashJump = Animator.StringToHash("Jump");
    static int hashSpeed = Animator.StringToHash("Speed");
    static int hashTurn = Animator.StringToHash("Turn");
    static int hashDirection = Animator.StringToHash("Direction");

    private Rigidbody rb;
    private Animator animator;

    [SerializeField, HideInInspector] float rayCastOffset;

    private float axis;
    private float jumpSpeed = 5f;

    //前フレームでの向き、方向転換に使う
    private float prevDirection;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        //前を向いた状態から開始
        prevDirection = 1;
    }

    private void Update()
    {
        axis = Input.GetAxis("Horizontal") ;

        bool isOnGround = Physics.Raycast(transform.position, Vector3.down, rayCastOffset);
        if(isOnGround) animator.SetBool(hashJump, false); 
        
        
        if(axis != 0)
        {
            float currentDirection = Mathf.Sign(axis);
            
            if(prevDirection != currentDirection) { 
                
                animator.SetTrigger(hashTurn);
                transform.forward = transform.forward * -1;

                Debug.Log(currentDirection);

                prevDirection = currentDirection;
                animator.SetFloat(hashDirection, currentDirection);
            }

            animator.SetFloat(hashSpeed, Mathf.Abs(axis * 3));
            
        }

        Vector3 velocity = rb.velocity;
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool(hashJump, true);
            velocity.y = jumpSpeed;
        }

        rb.velocity = velocity;

    }
}
