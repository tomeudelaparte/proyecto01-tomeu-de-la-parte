using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    private float turnSpeed = 50.0f;
    private float horizontalInput;

    private void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.position = player.transform.position + offset;
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
