using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnEvent : MonoBehaviour
{
    public int count = 0;
    /*
      事件 Event：

      在特定時間點以指定次數執行的區塊。
      官方文件：https://docs.unity3d.com/Manual/ExecutionOrder.html
    */
    //開始事件
    private void Start()    //程式開始時會跑一次
    {
        //使用 API 方法 : 方法名稱();
        print("九頭瞜拉！！！");
        print(count);
    }

    //更新事件

    private void Update()
    {
        //一秒鐘更新60次,會依照電腦效能去跑。

        print("姆打姆打姆打姆打姆打姆打姆打姆打姆打姆打姆打姆打");

    }




}
