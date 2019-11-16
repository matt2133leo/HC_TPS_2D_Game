﻿using UnityEngine;

public class Ground : MonoBehaviour
{
    // 宣告變數 (定義欄位 field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // private 私人(隱藏)，public 公開(顯示)
    // int 整數
    [Header("移動速度"),Range(0,100)]
    public int speed = 10;

    [Header("變型元件")]
    public Transform ground; //抓取物件本身Transform程式

    private void Start()
    {
        //屬性
        //print(ground.position); //偵測是否有抓到Ground物件
    }

    private void Update()
    {
        // 呼叫方法
        Move();
    }

    // 方法 / 函式，Method / function 語法：
    // 修飾詞 方法類型 方法名稱 () { 陳述式(敘述、演算法) }
    // void 無傳回的類型

    /// <summary>
    /// 地板的移動方法。
    /// </summary>
    private void Move()
    {
        // 地板.位移(x, y, z);
        // Time.deltaTime 每幀的時間
        ground.Translate(-speed * Time.deltaTime, 0, 0); 
    }

}
