using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnEvent : MonoBehaviour
{
    /*
      事件 Event：

      在特定時間點以指定次數執行的區塊。
      官方文件：https://docs.unity3d.com/Manual/ExecutionOrder.html
    */
    //開始事件
    private void Start()    //程式開始時會跑一次
    {
        //使用 API 方法 : 方法名稱();
        print("哈囉！九頭瞜拉！！！");
    }
}
