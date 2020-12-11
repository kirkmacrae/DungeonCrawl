using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        //TODO: calculate min/max X/Ys based on current scene grid size
    }

    void Update()
    {
        Vector3 newPosition = new Vector3(Mathf.Clamp(player.position.x, minX, maxX), Mathf.Clamp(player.position.y, minY, maxY), player.position.z);

        transform.position = newPosition + cameraOffset;
        
    }
}
