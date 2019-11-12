using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [Header("目前分數"), Tooltip("當前遊玩的最高分")]
    public int Score = 0 ;    //目前分數
    [Header("最高分數"),Tooltip("曾經的最高分")]
    public int High_Score ;//最高分數



    private void Update()
    {
        addscore();
        highscore();
        bornpipe();
        gameover();
    }


    /// <summary>
    /// 加分的方法。
    /// </summary>
    public void addscore()
    {
       
    }

    /// <summary>
    /// 判定最高分的方法。
    /// </summary>
    private void highscore()
    {

    }

    /// <summary>
    /// 生成水管的方法。
    /// </summary>
    private void bornpipe()
    {

    }

    /// <summary>
    /// 遊戲失敗的方法。
    /// </summary>
    private void gameover()
    {

    }

}
