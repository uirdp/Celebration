using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCamera_Platform : MonoBehaviour
{
    [SerializeField]
    [Tooltip("target")]
    Transform target = null;
    [SerializeField]
    [Tooltip("lerpTime")]
    float lerpTime = 1;
    [SerializeField]
    private float x_offset = 0;
    [SerializeField]
    private float y_offset = 0;
    [SerializeField]
    private float z_offset = 0;

    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = initialPosition;
        targetPosition.x += target.position.x + x_offset;
        targetPosition.y +=y_offset;
        targetPosition.z += target.position.z + z_offset;

        transform.position = Vector3.Lerp(transform.position, targetPosition, lerpTime);
    }
}
