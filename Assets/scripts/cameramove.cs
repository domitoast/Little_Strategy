using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public float movespeed = 2f;
    public float LeftLimit = -8f;
    public float RightLimit = 12f;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.mousePosition.x;


        // 檢查是否超出左右限制
        if (mouseX < Screen.width * 0.1f && transform.position.x > LeftLimit)
        {
            // 在左邊移動
            transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        }
        else if (mouseX > Screen.width * 0.9f && transform.position.x < RightLimit)
        {
            // 在右邊移動
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }
    }
}
