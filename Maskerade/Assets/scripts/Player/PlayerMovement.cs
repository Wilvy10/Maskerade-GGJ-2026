//using System.Diagnostics;
//using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
        rb.linearVelocity.Normalize();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
