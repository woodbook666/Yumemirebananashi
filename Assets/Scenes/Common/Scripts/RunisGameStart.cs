using UnityEngine;

public class RunisGameStart : MonoBehaviour
{
    // ゲーム起動時に実行
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void RunisGameStartMethod()
    {
        // 設定を復元
        if (PlayerPrefs.GetInt("isFullScreen", 0) == 1)
        {
            Screen.fullScreen = true;
        }
        if (PlayerPrefs.GetFloat("volume", 1) != 1)
        {
            AudioListener.volume = PlayerPrefs.GetFloat("volume");
        }
    }
}
