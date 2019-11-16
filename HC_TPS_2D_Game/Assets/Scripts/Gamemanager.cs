using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [Header("目前分數"), Tooltip("當前遊玩的最高分")]
    public int Score = 0 ;    //目前分數
    [Header("最高分數"),Tooltip("曾經的最高分")]
    public int High_Score ;//最高分數
    [Header("水管"), Tooltip("生成水管")]
    // GameObject 可以存放場景上的遊戲物件與專案內的預置物
    public GameObject pipe;



    private void Update()
    {
        addscore();
        highscore();
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
        // 生成(物件);
        //   Instantiate(pipe); //等於Object.Instantiate(pipe), 生成物件在原本預置物的位置

        //生成(物件，座標，角度);
        float y = Random.Range(-1f, 1f);
        //區域欄位(不需要修飾詞);
        Vector3 pos = new Vector3(10, y, 0);

        //Quaternion.identity 代表零角度
        Instantiate(pipe, pos, Quaternion.identity);
       
     
    }

    /// <summary>
    /// 遊戲失敗的方法。
    /// </summary>
    private void gameover()
    {

    }

    private void Start()
    {
        //重複調用("方法名稱", 開始時間, 間隔時間) 
        InvokeRepeating("bornpipe", 0, 2f); 

    }
}
