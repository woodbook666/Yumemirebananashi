using UnityEngine;

public class Player_TPSCamera : MonoBehaviour
{
    // 回転速度(マウスの感度)
    float rotateSpeed;
    // ズーム速度
    float zoomSpeed = 1;

    // プレイヤーのTransform
    Transform playerTrans;
    // マウスの動作
    float xMouse;
    float yMouse;

    // Start is called before the first frame update
    void Start()
    {
        // 回転速度(マウスの感度)を取得
        rotateSpeed = PlayerPrefs.GetFloat("mouseSensitivity", 3);
        // プレイヤーのTransformを取得
        playerTrans = GameObject.Find("YakiuMin_ver1.0.0").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // マウスの動きを取得
        xMouse +=  Input.GetAxis("Mouse X") * rotateSpeed;
        yMouse -= Input.GetAxis("Mouse Y") * rotateSpeed;

        // 縦回転を制限(制限角度より+22.5fしたオイラー角)
        yMouse = Mathf.Clamp(yMouse, -57.5f, 72.5f);
        // マウスの動きに合わせてプレイヤーを横回転
        playerTrans.eulerAngles = new Vector3(0, xMouse, 0);
        // カメラから見たプレイヤーの方向を算出
        Quaternion playerRotate = Quaternion.LookRotation(playerTrans.position - transform.position);
        // マウスの動きに合わせてカメラを縦回転させプレイヤーの方向に向かせる
        transform.eulerAngles = new Vector3(yMouse - 22.5f, 0, 0) + playerRotate.eulerAngles;

        // マウスホイールの動きを取得
        float mouseWheelMove = Input.GetAxis("Mouse ScrollWheel");

        // マウスホイールの動きに合わせてカメラをズーム
        transform.position += playerTrans.forward * mouseWheelMove * zoomSpeed;
    }
}
