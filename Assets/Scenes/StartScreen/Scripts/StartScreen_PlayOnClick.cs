using UnityEngine;

public class StartScreen_PlayOnClick : MonoBehaviour
{
    // カメラの回転速度
    float camRotatespeed = 5;

    // カメラのTransform
    Transform camTrans;
    // カメラのオイラー角のY軸
    float camVecY;
    // ボタンが押されたか
    bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        // カメラのTransformを取得
        camTrans = Camera.main.transform;
        // カメラのオイラー角のY軸を取得
        camVecY = camTrans.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        // カメラのオイラー角のY軸を取得
        camVecY = camTrans.localEulerAngles.y;
        // ボタンが押されたらカメラを90°回転
        if (isPressed)
        {
            camTrans.rotation = Quaternion.Slerp(camTrans.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * camRotatespeed);
            if (camVecY >= 88.5f && camVecY <= 91.5f)
            {
                isPressed = false;
            }
        }
    }

    // ボタンクリック時の処理
    public void OnClick()
    {
        // ボタンが押されたことをUpdate()に伝達
        if (camVecY >= -1.5f && camVecY <= 1.5f)
        {
            isPressed = true;
        }
    }
}
