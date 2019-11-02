using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float XSpeed = 1.0f;
    public float YSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos += transform.right * Input.GetAxis("Horizontal") * XSpeed;
        pos += transform.forward * Input.GetAxis("Vertical") * YSpeed;
        transform.position = pos;
    }
}
