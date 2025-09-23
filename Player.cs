using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    [Header("Movement")]
    public float moveSpeed = 10f;
    Vector2 MovementInput;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        rb.velocity = MovementInput * moveSpeed;
    }
    
    public void Move(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
    }

}
