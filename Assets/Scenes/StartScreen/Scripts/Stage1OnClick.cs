using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Debug:↓が完成するまでの仮実装
using UnityEngine.SceneManagement;
//

public class Stage1OnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // Todo:フェードアウト&シーン切り替え&フェードイン
        //
        // Debug:↑が完成するまでの仮実装
        SceneManager.LoadScene("Stage 1");
        //
    }
}
