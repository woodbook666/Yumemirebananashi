using UnityEngine;

public class StartScreen_ExitOnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // ゲームを終了
        // Todo:フェードアウト
        //
        Application.Quit();
    }
}
