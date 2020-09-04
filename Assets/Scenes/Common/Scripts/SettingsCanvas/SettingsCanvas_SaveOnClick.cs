using UnityEngine;

public class SettingsCanvas_SaveOnClick : MonoBehaviour
{
    // アクティブにするGameObject
    [SerializeField] GameObject activeText;

    // ボタンクリック時の処理
    public void OnClick()
    {
        // 設定を保存
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
        // 保存完了した事を伝達
        activeText.SetActive(true);
    }
}
