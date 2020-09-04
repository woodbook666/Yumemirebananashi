using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseCanvas_ExitOnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // StartScreenを読み込む
        // Todo:フェードアウト&フェードイン
        //
        SceneManager.LoadScene("StartScreen");
    }
}
