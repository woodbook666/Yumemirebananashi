using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    // 回転速度(マウスの感度)
    float rotateSpeed;

    // プレイヤーのTransform
    Transform playerTrans;
    // マウスの動き
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

        // 縦回転を制限
        yMouse = Mathf.Clamp(yMouse, -120, 90);
        // マウスの動きに合わせてプレイヤーを横回転
        playerTrans.eulerAngles = new Vector3(0, xMouse, 0);
        // マウスの動きに合わせてカメラを回転
        transform.eulerAngles = new Vector3(yMouse, xMouse, 0);
    }
}
