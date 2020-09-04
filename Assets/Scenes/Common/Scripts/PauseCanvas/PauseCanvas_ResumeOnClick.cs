using UnityEngine;

public class PauseCanvas_ResumeOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 設定を保存
        PlayerPrefs.Save();
    }

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
        // 一時停止画面を消す
        Cursor.visible = false;
        Destroy(GameObject.Find("PauseCanvas(Clone)"));
        GameObject.Find("PauseResume").GetComponent<Player_PauseResume>().Resume();
    }
}
