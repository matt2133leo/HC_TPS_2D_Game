using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // 引用 介面 API 要用介面一定要輸入這個

public class Gamemanager : MonoBehaviour
{
    [Header("目前分數"), Tooltip("當前遊玩的最高分")]
    public static int Score = 0 ;    //目前分數
    [Header("最高分數"),Tooltip("曾經的最高分")]
    public int High_Score ;//最高分數
    [Header("水管"), Tooltip("生成水管")]
    // GameObject 可以存放場景上的遊戲物件與專案內的預置物
    public GameObject pipe;
    [Header("遊戲結算畫面")]
    public GameObject goFinal;
    //static 不會顯示在屬性 Inspector 面板上
    [Header("遊戲結束")]
    public static bool gameOver;

    [Header("分數欄位")]
    public Text ChickenpassScore;

    [Header("最佳分數")]
    public Text textBest;

    private void Start()    //遊戲開始與載入場景會執行一次
    {
        //螢幕.設定解析度(寬，高，是否全螢幕)
        Screen.SetResolution(450, 800, false);

        //靜態成員再載入場景都不會還原
        gameOver = false;

        Score = 0;

        //重複調用("方法名稱", 開始時間, 間隔時間) 
        InvokeRepeating("bornpipe", 0, 2f);
        textBest.text = PlayerPrefs.GetInt("最佳分數").ToString();
    }

    private void Update()
    {

    }

    #region 分數 與 最高分

    /// <summary>
    /// 加分的方法。
    /// </summary>
    public void addscore()
    {
        //   print("加分");

        Score++;
        // 分數介面.文字內容 = 分數.轉為自傳
        // ToString() 可以將任何類型轉呈字串。
        ChickenpassScore.text = Score.ToString();
        //呼叫最佳分數判定
        highscore();
        textBest.text = PlayerPrefs.GetInt("最佳分數").ToString();
    }

    /// <summary>
    /// 判定最高分的方法。
    /// </summary>
    private void highscore()
    {
        //如果 目前分數>最佳分數
        //玩家資料.設定整數("最佳分數",目前分數)
        if (Score > PlayerPrefs.GetInt("最佳分數"))
        {
            PlayerPrefs.SetInt("最佳分數", Score);
        }

    }
    #endregion
    #region 生成水管與遊戲失敗
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
    public void gameover()
    {
        goFinal.SetActive(true); // 顯示結算畫面
        gameOver = true;         // 遊戲結束 = 是
        CancelInvoke("bornpipe"); // 停止 InvokeRepeating 、Invoke 的方法
    }
    #endregion
    #region 遊戲重新開始與離開遊戲
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit(); //使用應用程式.離開();
    }
    /// <summary>
    /// 重新開始遊戲
    /// </summary>
    public void Replay()
    {
        //Application.LoadLevel("遊戲場景"); // 應用程式.載入場景("場景名稱");←舊版API
        SceneManager.LoadScene(0); //需添加using UnityEngine.SceneManagement;  場景管理器.載入場景("場景名稱"); ←新版API
    }
    #endregion
}
