using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 移動スピード
    float speed = 15.0f;
    // ジャンプ力
    float jumpForce = 250.0f;

    // Rigidbody
    Rigidbody rb;
    // Animator
    Animator animator;

    // 現在位置
    Vector3 playerPosition;
    // 今の状態
    int state;
    // 少し前の状態
    int prevState;
    // 地面に接触してるか
    bool ground = true;
    // キーが押されているか
    bool pushKey = false;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
        // Animatorを取得
        animator = GetComponent<Animator>();
        // 現在位置を取得
        playerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // キーが押されているか判定
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            pushKey = true;
        }
        else
        {
            pushKey = false;
        }

        // 今の状態を取得
        // stateが0なら待機状態、1なら走っている、2ならジャンプ中
        if (ground)
        {
            if (!pushKey)
            {
                state = 0;
            }
            else
            {
                state = 1;
            }
        }
        else
        {
            state = 2;
        }

        // 今の状態が少し前の状態と変化していたらアニメーションを変える
        if (prevState != state)
        {
            switch (state)
            {
                case 0:
                    animator.SetBool("Idling", true);
                    animator.SetBool("Running", false);
                    animator.SetBool("Jumping", false);
                    break;
                case 1:
                    animator.SetBool("Idling", false);
                    animator.SetBool("Running", true);
                    animator.SetBool("Jumping", false);
                    break;
                case 2:
                    animator.SetBool("Idling", false);
                    animator.SetBool("Running", false);
                    animator.SetBool("Jumping", true);
                    break;
            }

            // 少し前の状態を更新
            prevState = state;
        }

        // 入力されたキーに合わせてモデルを動かす
        if (ground && Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up * jumpForce);
            ground = false;
        }
        rb.MovePosition(transform.position + new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed));

        // 方向転換
        Vector3 direction = transform.position - playerPosition;
        if (direction.magnitude >= 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        }

        // 現在位置を更新
        playerPosition = transform.position;
    }

    // ジャンプ後地面に接触したか判定
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Ground" && !ground)
        {
            ground = true;
        }
    }
}
