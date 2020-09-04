using UnityEngine;

public class StartScreen_SettingsOnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // 設定画面を読み込んで表示
        // Todo:フェードイン
        //
        Instantiate(Resources.Load("SettingsCanvas"));
    }
}
