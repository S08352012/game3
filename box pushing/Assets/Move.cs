using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public static int Score;        //宣告次數參數
    public Text ShowScore;          //宣告文字UI

    
    void Start()
    {
        Score = 0;
    }


    void Update()
    {
          ShowScore.text = Score.ToString();        //讓UI文字與次數同步
    }
}
