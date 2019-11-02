using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public Transform YAxis;
    public Transform XAxis;

    public float XSpeed = 1.0f;
    public float YSpeed = 1.0f;

    private void Start()
    {
        //マウスカーソル消したければこのコメントアウトを外す
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X") * XSpeed;
        float Y_Rotation = Input.GetAxis("Mouse Y") * YSpeed;
        YAxis.transform.Rotate(0, -X_Rotation, 0);
        XAxis.transform.Rotate(Y_Rotation, 0, 0);
    }
}
