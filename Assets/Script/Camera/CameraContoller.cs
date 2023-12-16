using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{

    [SerializeField] GameObject player;

    [Header("�J������x���𒲐��A�傫������ƃv���C���[���[��")]
    [SerializeField] float offsetSize;

    private Vector3 centre;

    private void FollowPlayer()
    {
        Vector3 offset = new Vector3(0, offsetSize * player.transform.rotation.y * 10, 0);
        transform.position = player.transform.position + centre + offset;
    }

    private void Start()
    {
        //�J�����̈ʒu���v���C���[���S�ɒ���
        transform.position = new Vector3(transform.position.x, transform.position.y,
                                         player.transform.position.z);

        centre = this.transform.position - player.transform.position;
    }

    private void Update()
    {
        FollowPlayer();
    }
}
