using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 OffSet;


    // Update camera position relevant to player
    void Update()
    {
        transform.position = player.position + OffSet;

    }
}
