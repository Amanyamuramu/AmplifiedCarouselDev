using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        // CharacterControllerを取得
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 接地しているなら
        if (controller.isGrounded)
        {
            // スペースキーでジャンプ
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // ジャンプ力を設定
                moveDirection.y = 5;
            }
        }

        // 重力計算
        moveDirection.y -= 2 * Time.deltaTime;

        // Cubeを動かす処理
        controller.Move(moveDirection * Time.deltaTime);
    }
}