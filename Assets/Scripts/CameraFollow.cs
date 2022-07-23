using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject FollowThePlayer;
    void LateUpdate()
    {
        transform.position = FollowThePlayer.transform.position + new Vector3(0, 0, -10);
    }
}
