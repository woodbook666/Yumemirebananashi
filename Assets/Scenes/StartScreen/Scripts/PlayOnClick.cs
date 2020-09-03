using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    // カメラの回転速度
    float camRotatespeed = 5.0f;

    // カメラのTransform
    Transform camTrans;
    // カメラのオイラー角のy軸
    float camVecY;
    // ボタンが押されたか
    bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        // カメラのTransformを取得
        camTrans = Camera.main.transform;
        // カメラのオイラー角のy軸を更新
        camVecY = camTrans.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        // カメラのオイラー角のy軸を更新
        camVecY = camTrans.localEulerAngles.y;
        // ボタンが押されたらカメラを90°回転させる
        if (isPressed)
        {
            camTrans.rotation = Quaternion.Slerp(camTrans.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * camRotatespeed);

            // 回転終了を検知
            if (camVecY >= 88.5f && camVecY <= 91.5f)
            {
                isPressed = false;
            }
        }
    }

    // ボタンクリック時の処理
    public void OnClick()
    {
        // ボタンが押されたことをUpdate()に伝える
        if (camVecY >= -1.5f && camVecY <= 1.5f)
        {
            isPressed = true;
        }
    }
}
