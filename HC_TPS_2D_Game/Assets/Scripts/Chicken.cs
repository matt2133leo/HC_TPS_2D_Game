using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度"), Tooltip("點一下往上飛的距離"), Range(0f,2000f)]
    public float Jumphigh = 0.1f; //小雞跳躍高度
    [Header("旋轉角度"), Range(0f, 1000f)]
    public float ChickenAngle = 10f;
    [Header("死亡判定"), Tooltip("角色是否死亡,打勾就死,沒打勾就沒死")]
    public bool Dead = false;  //小雞死亡
    [Header("剛體")]
    public Rigidbody2D Chickenr2d;

    private void FixedUpdate() // 固定幀數 0.002 一幀：要控制物理請寫在此事件內。
    {
        Jump();
        dead();
    }

    /// <summary>
    /// 小雞跳躍的方法。
    /// </summary>
    private void Jump()
    {
        //如果 玩家 按下左鍵
        //輸入.按下按鍵(按鍵列舉.滑鼠左鍵) (手機觸控也可)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("玩家按下左鍵~");
            Chickenr2d.Sleep();
            Chickenr2d.gravityScale = 1; // 小雞剛體.重力 = 1 ;
            //小雞往上跳
            Chickenr2d.AddForce(new Vector2(0, Jumphigh)); //小雞剛體.增加推力(二為向量(左右,上下));
        }

        // Rigidbody2D.SetRotation(float) 設定角度(角度)
        // Rigidbody2D.velcotiy 加速度 (二維向量 x , y)
        Chickenr2d.SetRotation(ChickenAngle * Chickenr2d.velocity.y * Time.deltaTime);

    }

    /// <summary>
    /// 小雞死亡的方法。
    /// </summary>
    private void dead()
    {

    }






}
