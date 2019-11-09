using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [Header("目前分數"), Tooltip("當前遊玩的最高分")]
    public int Score = 0 ;    //目前分數
    [Header("最高分數"),Tooltip("曾經的最高分")]
    public int High_Score ;//最高分數

}
