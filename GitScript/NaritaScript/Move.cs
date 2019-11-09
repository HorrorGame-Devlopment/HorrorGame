using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float ZSpeed = 1.0f;

    private float mMoveZ = 0.0f;
    // Update is called once per frame
    void Update()
    {
        mMoveZ = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        var velocity = new Vector3(0, 0, mMoveZ);
        velocity = transform.TransformDirection(velocity) * ZSpeed;
        transform.localPosition += velocity * Time.fixedDeltaTime;
    }
}
