using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    // 回転速度
    float rotateSpeed = 3.0f;
    // ズーム速度
    float zoomSpeed = 1.0f;

    // プレイヤーのTransform
    Transform playerTrans;
    // マウスの動き
    float xMouse;
    float yMouse;

    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーのTransformを取得
        playerTrans = GameObject.Find("YakiuMin_ver1.0.0").transform;
        // マウスカーソルを非表示に
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // マウスの動きを取得
        xMouse +=  Input.GetAxis("Mouse X") * rotateSpeed;
        yMouse -= Input.GetAxis("Mouse Y") * rotateSpeed;

        // 縦回転を制限
        yMouse = Mathf.Clamp(yMouse, -80, 50);
        // マウスの動きに合わせてプレイヤーを横回転
        playerTrans.eulerAngles = new Vector3(0.0f, xMouse, 0.0f);
        // カメラから見たプレイヤーの方向を算出
        Quaternion playerRotate = Quaternion.LookRotation(playerTrans.position - transform.position);
        // マウスの動きに合わせてカメラを縦回転させプレイヤーの方向に向かせる
        transform.eulerAngles = new Vector3(yMouse, 0.0f, 0.0f) + playerRotate.eulerAngles;

        // マウスホイールの動きを取得
        float mouseWheelMove = Input.GetAxis("Mouse ScrollWheel");
        // マウスホイールの動きに合わせてカメラをズーム
        transform.position += playerTrans.forward * mouseWheelMove * zoomSpeed;
        // Todo:ズームを制限
        //
    }
}
