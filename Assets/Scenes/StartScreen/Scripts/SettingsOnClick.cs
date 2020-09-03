using UnityEngine;

public class SettingsOnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // 設定画面を読み込む
        Instantiate(Resources.Load("SettingsCanvas"));
    }
}
