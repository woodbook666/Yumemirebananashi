using UnityEngine;
using UnityEngine.UI;

public class VolumeOnChenged : MonoBehaviour
{
    // Slider
    Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        // Sliderを取得
        volumeSlider = GetComponent<Slider>();
        // 設定の値によってSliderの状態を変更
        if (PlayerPrefs.GetFloat("volume", 1) != 1)
        {
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
        }
    }

    // スライダーを変更時の処理
    public void OnChenged()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }
}
