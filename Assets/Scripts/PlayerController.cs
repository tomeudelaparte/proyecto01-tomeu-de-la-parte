using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 10.0f;
    private float rotateSpeed = 80.0f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // Tomamos eje horizontal del Input Manager
        horizontalInput = Input.GetAxis("Horizontal");
        // Tomamos eje horizontal del Input Manager
        verticalInput = Input.GetAxis("Vertical");

        // Movimiento vertical (W, S)
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        // Movimiento horizontal (A, D)
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        // Rotación horizontal (A, D)
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime * horizontalInput);
    }
}
