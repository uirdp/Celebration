using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{

    [SerializeField] GameObject player;

    [Header("カメラのx軸を調整、大きくするとプレイヤーが端に")]
    [SerializeField] float offsetSize;

    private Vector3 centre;

    private void FollowPlayer()
    {
        Vector3 offset = new Vector3(0, offsetSize * player.transform.rotation.y * 10, 0);
        transform.position = player.transform.position + centre + offset;
    }

    private void Start()
    {
        //カメラの位置をプレイヤー中心に調整
        transform.position = new Vector3(transform.position.x, transform.position.y,
                                         player.transform.position.z);

        centre = this.transform.position - player.transform.position;
    }

    private void Update()
    {
        FollowPlayer();
    }
}
