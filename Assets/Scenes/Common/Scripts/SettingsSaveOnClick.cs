using UnityEngine;

public class SettingsSaveOnClick : MonoBehaviour
{
    // アクティブにするGameObjectを取得
    [SerializeField] GameObject activeText;

    // ボタンクリック時の処理
    public void OnClick()
    {
        // 設定をセーブ
        if (PlayerPrefs.GetInt("isFullScreen", 0) == 1)
        {
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
        }
        else
        {
            Screen.fullScreen = false;
        }
        if (PlayerPrefs.GetFloat("volume", -1) != -1)
        {
            AudioListener.volume = PlayerPrefs.GetFloat("volume");
        }
        PlayerPrefs.Save();
        // セーブ完了した事を伝える
        activeText.SetActive(true);
    }
}
