using UnityEngine;

public class SettingsCanvas_BackOnClick : MonoBehaviour
{
    // 受け渡し用の変数
    public bool isOpenPauseCanvas;

    // Update is called once per frame
    void Update()
    {
        // Escapeキーが押されたらOnClick()を実行
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnClick();
        }
    }

    // ボタンクリック時の処理
    public void OnClick()
    {
        // 設定画面を消す
        Destroy(GameObject.Find("SettingsCanvas(Clone)"));
        if (isOpenPauseCanvas)
        {
            Instantiate(Resources.Load("PauseCanvas"));
        }
    }
}
