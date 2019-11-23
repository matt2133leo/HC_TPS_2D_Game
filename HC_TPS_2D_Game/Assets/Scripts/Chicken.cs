using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度"), Tooltip("點一下往上飛的距離"), Range(0f, 2000f)]
    public float Jumphigh = 0.1f; //小雞跳躍高度
    [Header("旋轉角度"), Range(0f, 1000f)]
    public float ChickenAngle = 10f;
    [Header("死亡判定"), Tooltip("角色是否死亡,打勾就死,沒打勾就沒死")]
    public bool Dead = false;  //小雞死亡
    [Header("剛體")]
    public Rigidbody2D Chickenr2d;
    [Header("物件控制")]
    public GameObject goScore, goGM;
    [Header("地板程式運作")]
    public Ground goGround;
    [Header("控制死亡與開始")]
    public Gamemanager gm;

    [Header("存放喇叭元件")]
    public AudioSource Chickenaud;

    [Header("存放音效檔案")]
    public AudioClip soundJump, soundHit, soundAdd;

    private void Update() // 固定幀數 0.002 一幀：要控制物理請寫在此事件內。
    {
        Jump();
       
    }
    #region 小雞的跳躍、加分、音效
    /// <summary>
    /// 小雞跳躍的方法。
    /// </summary>
    private void Jump()
    {
        //原始寫法
        //if(Dead == true)
        //{
        //    return; // 他會直接跳出此方法程式
        //}


        // 如果 死亡 跳出此程式區塊
        // 判斷是只有一行敘述可以省略大括號
        if (Dead) return; //簡寫


        //如果 玩家 按下左鍵
        //輸入.按下按鍵(按鍵列舉.滑鼠左鍵) (手機觸控也可)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("玩家按下左鍵~");
            Chickenaud.PlayOneShot(soundJump, 1.5f);
            Chickenr2d.Sleep();
            Chickenr2d.WakeUp();
            Chickenr2d.gravityScale = 1; // 小雞剛體.重力 = 1 ;
            //小雞往上跳
            Chickenr2d.AddForce(new Vector2(0, Jumphigh)); //小雞剛體.增加推力(二為向量(左右,上下));
            //分數顯示
            goScore.SetActive(true);
            //GM顯示
            goGM.SetActive(true);
            //地板運作
            goGround.enabled = true;

        }

        // Rigidbody2D.SetRotation(float) 設定角度(角度)
        // Rigidbody2D.velcotiy 加速度 (二維向量 x , y)
        Chickenr2d.SetRotation(ChickenAngle * Chickenr2d.velocity.y * Time.deltaTime);

    }
    #endregion
    #region 小雞死亡
    /// <summary>
    /// 小雞死亡的方法。
    /// </summary>
    private void dead()
    {
        if (Dead == true) 
        { 
            return; 
        }
        else if (Dead == false)
        {
            print("死了");
            Chickenaud.PlayOneShot(soundHit, 1.5f);
            Dead = true;
            gm.gameover();
        }
    }

    //事件：碰撞開始 - 碰撞開始時執行一次 (Collision2D collision) (碰撞類別 名稱) 存放碰到物件的資訊
    private void OnCollisionEnter2D(Collision2D hit)
    {
        print(hit.gameObject.name);

        if(hit.gameObject.name == "地板")
        {
            dead();

        }

    }
    #endregion
    #region 水管與加分
    // 事件：觸發開始-物件必須勾選 IsTrigger
    private void OnTriggerEnter2D(Collider2D hit)
    {
        //如果 碰到.物件名稱 為 水管-上 或 水管-下 則 死亡 
        //OnTriggerEnter/Exit/Stay 皆可以省略gameobject 
        if (hit.name == "水管-上" || hit.name == "水管-下") 
        {
            dead();

        }
    }

    private void OnTriggerExit2D(Collider2D hit)
    {
        if(hit.name == "加分")
        {
            Chickenaud.PlayOneShot(soundAdd, 1.5f);
            gm.addscore();
        }
    }

    #endregion
}
