using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度"), Tooltip("點一下往上飛的距離"), Range(0f,2000f)]
    public float Jumphigh = 0.1f; //小雞跳躍高度
    [Header("死亡判定"), Tooltip("角色是否死亡,打勾就死,沒打勾就沒死")]
    public bool Dead = false;  //小雞死亡


    private void Update()
    {
        Jump();
        dead();
    }

    /// <summary>
    /// 小雞跳躍的方法。
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 小雞死亡的方法。
    /// </summary>
    private void dead()
    {

    }


}
