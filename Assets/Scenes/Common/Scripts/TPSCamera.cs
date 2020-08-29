using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    // カメラの移動速度
    float speed = 3.0f;
    Vector3 cameraVec = new Vector3(0.0f, 3.0f, -3.0f);
    // やきう民のオブジェクト
    GameObject playerObj;

    // Start is called before the first frame update
    void Start()
    {
        // やきう民のオブジェクトを取得
        playerObj = GameObject.Find("YakiuMin_ver1.0.0");
    }

    void LateUpdate()
    {
        // やきう民の位置を追従する
        transform.position = Vector3.Lerp(transform.position, playerObj.transform.position + cameraVec, speed * Time.deltaTime);
        // Todo:やきう民に合わせて回転
        // Todo:マウス移動でカメラ回転(制限あり、マウスカーソル非表示？)
        // Todo:マウスホイールでカメラ拡縮(制限あり)
    }
}
