using UnityEngine;
using UnityEngine.UI;

public class SettingsCanvas_MouseSensitivityOnChenged : MonoBehaviour
{
    // Slider
    Slider mouseSensitivitySlider;

    // Start is called before the first frame update
    void Start()
    {
        // Sliderを取得
        mouseSensitivitySlider = GetComponent<Slider>();
        // 設定の値によってSliderの状態を変更
        if (PlayerPrefs.GetFloat("mouseSensitivity", 3) != 3)
        {
            mouseSensitivitySlider.value = PlayerPrefs.GetFloat("mouseSensitivity");
        }
    }

    // Sliderを変更時の処理
    public void OnChenged()
    {
        PlayerPrefs.SetFloat("mouseSensitivity", mouseSensitivitySlider.value);
    }
}
