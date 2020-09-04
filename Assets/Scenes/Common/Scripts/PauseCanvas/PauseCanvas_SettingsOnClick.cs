using UnityEngine;

public class PauseCanvas_SettingsOnClick : MonoBehaviour
{
    // ボタンクリック時の処理
    public void OnClick()
    {
        // 一時停止画面を消して設定画面を表示
        Destroy(GameObject.Find("PauseCanvas(Clone)"));
        GameObject settingsCanvas = Instantiate(Resources.Load("SettingsCanvas")) as GameObject;
        settingsCanvas.transform.Find("BackButton").GetComponent<SettingsCanvas_BackOnClick>().isOpenPauseCanvas = true;
    }
}
