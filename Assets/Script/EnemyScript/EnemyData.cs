using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "EnemyData")]
public class EnemyData : ScriptableObject
{
    public float speed;
    public float acc;

    public float verticalSpeed;
    public byte dir;
}
        