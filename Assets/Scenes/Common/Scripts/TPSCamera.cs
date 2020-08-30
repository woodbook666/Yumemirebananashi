using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    // やきう民のTransform
    Transform playerTrans;
    // マウスの動き
    float xMouse;
    float yMouse;
    // 回転する速度
    float rotateSpeed = 3.0f;
    // ズームする速度
    float zoomSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // やきう民のTransformを取得
        playerTrans = GameObject.Find("YakiuMin_ver1.0.0").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // マウス移動でカメラとやきう民を回転させる
        // マウスの動きを取得する
        xMouse +=  Input.GetAxis("Mouse X") * rotateSpeed;
        yMouse -= Input.GetAxis("Mouse Y") * rotateSpeed;

        // 縦回転を制限する
        yMouse = Mathf.Clamp(yMouse, -80, 50);
        // やきう民を横回転させる
        playerTrans.eulerAngles = new Vector3(0.0f, xMouse, 0.0f);
        // やきう民の方向を算出する
        Quaternion playerRotate = Quaternion.LookRotation(playerTrans.position - transform.position);
        // カメラを縦回転させやきう民の方向に向かせる
        transform.eulerAngles = new Vector3(yMouse, 0.0f, 0.0f) + playerRotate.eulerAngles;

        // マウスホイールでカメラを拡縮させる
        // マウスホイールの動きを取得する
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        // マウスホイールの動きに合わせてカメラをズームする
        transform.position += playerTrans.forward * mouseWheel * zoomSpeed;
        // Todo:ズームに制限をかける
    }
}
