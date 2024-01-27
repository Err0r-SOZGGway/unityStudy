using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public GameObject effect;

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Player") {
            if (col.relativeVelocity.magnitude > 5f) {
                Destroy(gameObject);
                GameObject obj = GameObject.Instantiate(effect) as GameObject;
                obj.transform.position = transform.position;
            }
        }
    }
}
