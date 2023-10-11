using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //player reference
    public GameObject player;

    //camera and player distance
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //difference between camera position and player
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame
    void LateUpdate()
    {
        //maintain difference between camera and player
        transform.position = player.transform.position + offset;
    }
}
