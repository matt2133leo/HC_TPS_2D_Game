using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnField : MonoBehaviour
{
    //定義欄位 Field
    //語法: 修飾詞 欄位類型 欄位名稱 (指定值) 結束
    [Header("角色等級"), Range(1,99)] //在欄位屬性上增加一個文字標示 
    public int lv = 1;
    [Tooltip("這是角色的移動速度")]   //滑鼠調整時會出現的提示
    [Range(0.1f, 99.9f)]              //只適用於數值型態,調整最大值與最小值
    public float speed = 1.5f;        //float數值內的"f"、"F"  唯一可用小寫跟大寫 , 不加f的話會被程式判斷成double型態
    public string prop1 = "紅色藥水"; 
    public bool mission = true;  

    /*
    整數: int         - 0,  1, 999, -100 (無小數點整數) -預設值為0
    浮點數: float     - -1.5 , -999.9, 100.5 (隨機數值,包含小數點) -預設值為0
    字串:  string     - 紅色藥水、鞋子(儲存任意文字) -預設值為空值    //string字串一定要用雙引號"文字"包
    布林值 bool(簡寫) - true、false -預設值為false
    p.s. 有很多定義，這四個遊戲內最常使用。
    */

    /*
     -欄位屬性
     [Header("")]     :欄位上顯示文字。
     [Tooltip("")]    :滑鼠移動到上方時會跳出題是訊息。
     [Range(min,MAX)] :最大值最小值設定。

    /*
     -修飾詞:
     -私人: 隱藏 private (預設)
     -公開: 顯示 public
    */

    //命名時使用有意義的代名詞去命名
    //注意大小寫,如有錯誤會有紅色波浪提醒
    //Unity的數值依照Unity以屬性面板為主，記得Reset
    //習慣作註解,不要取什麼a1 a2 a3這種鳥東西。
    //可將欄位屬性
}