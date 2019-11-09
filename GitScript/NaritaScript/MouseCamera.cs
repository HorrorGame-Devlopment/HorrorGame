using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    [Header("首の横の動きをさせるオブジェクト")]
    public Transform YAxis;
    [Header("首の縦の動きをさせるオブジェクト")]
    public Transform XAxis;

    [Header("首の横の動きの感度")]
    public float XSpeed = 1.0f;
    [Header("首の縦の動きの感度")]
    public float YSpeed = 1.0f;

    [Header("首の縦の動きの限界角度")]
    public float LimitXAxizAngle = 30;

    //首の縦の動きを反映させるためのvector3
    private Vector3 mXAxiz;
    private void Start()
    {
        //カーソルをロックする
        Cursor.lockState = CursorLockMode.Locked;
        //カーソルを見えなくする
        Cursor.visible = false;

        //初期角度を取得して置く
        mXAxiz = XAxis.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //首の横の動きを計算
        float X_Rotation = Input.GetAxis("Mouse X") * XSpeed * Time.deltaTime;
        //反映
        YAxis.transform.Rotate(0, -X_Rotation, 0);

        //首の縦の動きを計算
        float Y_Rotation = Input.GetAxis("Mouse Y") * YSpeed * Time.deltaTime;
        var x = mXAxiz.x + Y_Rotation;
        //角度検証
        if (x >= -LimitXAxizAngle && x <= LimitXAxizAngle)
        {
            //問題無ければ反映
            mXAxiz.x = x;
            XAxis.localEulerAngles = mXAxiz;
        }
    }
}
