using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform transformA;
    public Transform transformB;
    public Camera CameraSize;

    //練習

    public AudioSource muteBGM;

    private void Start()
    {
        #region 靜態與非靜態
        // 使用靜態成員 - 屬性
        print("隨機:" + Random.value);

        // 使用 - 屬性 數學類別 Mathf.PI 
        print("PI:" + Mathf.PI);

        // 使用靜態成員 - 方法
        print("隨機範圍:"+Random.Range(1, 100));
        print("絕對值:" + Mathf.Abs(-99));

        // 非靜態成員 - 屬性
        // 需要先給予欄位存放實體物件
        print("物件A的座標:" + transformA.position);

        transformB.position = new Vector3(-2, 0, 0);
        print("物件B的座標:" + transformB.position);

        CameraSize.depth = 10;
        print("攝影機的Size:" + CameraSize.depth);
        #endregion

        #region 練習
        muteBGM.mute = true; 
        #endregion

    }

    private void Update()
    {
        //非靜態成員 - 方法
        transformB.Rotate(0, 0, 10);
    }
}


