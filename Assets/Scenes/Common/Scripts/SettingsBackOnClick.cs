using UnityEngine;

public class SettingsBackOnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // 設定画面を消す
        Destroy(GameObject.Find("SettingsCanvas(Clone)"));
    }
}
