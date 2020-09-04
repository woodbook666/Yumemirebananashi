using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen_Stage1OnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // Stage 1を読み込んで表示
        // Todo:フェードアウト&フェードイン
        //
        SceneManager.LoadScene("Stage 1");
    }
}
