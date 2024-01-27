using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    public float speed = 7f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float addX = speed * x * Time.deltaTime;
        float addZ = speed * z * Time.deltaTime;

        transform.GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(addX, 0, addZ));
        transform.LookAt(transform.position + new Vector3(addX, 0, addZ));
    }
}
