using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 
/// Responsible for moving the player automatically and 
/// receiving input. 
/// </summary> 

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{
    /// <summary> 
    /// A reference to the Rigidbody component 
    /// </summary> 
    private Rigidbody rb;

    [Tooltip("How fast the ball moves left/right")]
    public float dodgeSpeed = 1;

    [Tooltip("How fast the ball moves forwards automatically")]
    [Range(0, 10)]
    public float rollSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Get access to our Rigidbody component 
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// FixedUpdate is called at a fixed framerate and is a prime place to put
    /// to put
    /// Anything based on time.
    /// </summary>
    void Update()
    {
        // Check if we're moving to the side 
        var horizontalSpeed = Input.GetAxis("Horizontal") *
        dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }
}

