using UnityEngine;

public class Player_PauseResume : MonoBehaviour
{
    // 再開するRigidbody
    Rigidbody resumeRigidbody;
    // 再開するAnimator
    Animator resumeAnimator;
    // Rigidbodyの速度の保存場所
    Vector3 angularVelocityTemp;
    Vector3 velocityTemp;

    // プレイヤーとカメラを一時停止
    public void Pause(Rigidbody pauseRigidbody, Animator pauseAnimator)
    {
        // 保存
        resumeRigidbody = pauseRigidbody;
        resumeAnimator = pauseAnimator;
        angularVelocityTemp = pauseRigidbody.angularVelocity;
        velocityTemp = pauseRigidbody.velocity;
        // 一時停止
        if (PlayerPrefs.GetInt("enabledFPSCamera", 0) == 0)
        {
            Camera.main.gameObject.GetComponent<Player_TPSCamera>().enabled = false;
        }
        else
        {
            GameObject.Find("Sub Camera").GetComponent<Player_FPSCamera>().enabled = false;
        }
        pauseRigidbody.isKinematic = true;
        pauseAnimator.speed = 0;
    }

    // プレイヤーとカメラを再開
    public void Resume()
    {
        // 復元
        resumeRigidbody.angularVelocity = angularVelocityTemp;
        resumeRigidbody.velocity = velocityTemp;
        // 再開
        if (PlayerPrefs.GetInt("enabledFPSCamera", 0) == 0)
        {
            Camera.main.gameObject.GetComponent<Player_TPSCamera>().enabled = true;
        }
        else
        {
            GameObject.Find("Sub Camera").GetComponent<Player_FPSCamera>().enabled = true;
        }
        resumeRigidbody.isKinematic = false;
        resumeAnimator.speed = 1;
    }
}
