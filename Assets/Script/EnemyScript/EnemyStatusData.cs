using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class EnemyStatusData : ScriptableObject
{
    public float speed;
    public float acc;

    public float verticalSpeed;
    public sbyte dir;
}
        