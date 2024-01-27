using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // speed‚ğ§Œä‚·‚é
    public float speed = 10;
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // x‚Æz‚Éspeed‚ğŠ|‚¯‚é
        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}
