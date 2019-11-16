using UnityEngine;

public class LearnIF : MonoBehaviour
{
    [Header("血量"), Range(0,100),Tooltip("玩家血量")]
    public int Hp = 100;

    public bool test;

    public string prop;

    //更新事件: 一秒執行60次
    private void Update()
    {
        #region if講解
        /*
        //判斷式 if 語法
        //if (布林值) { 陳述式或演算法}
        //() 裡面的布林值為 true 才會執行 {陳述式或演算法}
        if (test)
        {
            print("打開開關~");
        }
        // () 裡面的布林值為 false 才會執行else{}
        else
        {
            print("關閉開關!");
        }

        if (prop == "紅色藥水") 
        {
            print("補血");
        }
        else if (prop == "藍色藥水") 
        {
            print("補魔力");
        }
        else if (prop == "黃色藥水") 
        {
            print("補體力");
        }
        else
        {
            print("沒發生任何事情!");
        }
        */
        #endregion

        #region if練習
        if (Hp <= 20 && Hp > 0) //老師範例:(Hp >= 70)
        {
            print("快死了");
        }
        else if (Hp <= 50 && Hp > 20) //老師範例:(Hp >= 50)
        {
            print("危險");
        }
        else if (Hp <= 70 && Hp > 50) //老師範例:(Hp >= 20)
        {
            print("警告");
        }
        else if (Hp <= 100 && Hp > 70) //老師範例:else {}
        {
            print("安全");
        }
        else
        {
            print("死了啦!");

        }
        #endregion
    } 
}