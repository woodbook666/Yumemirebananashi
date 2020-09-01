using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // Todo:フェードアウト
        //
        // ゲームを終了
        Application.Quit();
    }
}
