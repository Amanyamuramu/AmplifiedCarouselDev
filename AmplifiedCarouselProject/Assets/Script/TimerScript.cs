using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    // [Header("実験に用いるためのパラメタ")]
    // [Space(10)]

    [Header("周期 [sec]")]
    public float span = 3.5f; 

    [Header("周期(now sec) [sec]")]
    public float countdown = 0.0f; //一回の周期にかかる時間（）[sec]

    [Header("1周期のカウンター")]
    public int counter = 0;

    [Header("振幅の大きさ(強度)")]
    public float amp = 1f;

    [Header("加速度装置との位相差(実際にはcase文)")]
    public int pi = 0;

    [Header("透明度(100=不透明)")]
    public int transparency = 100;
    [Header("テクスチャ勾配の位置")]
    public float stimulHeight = 0f;
    public bool updown = false; //上昇降下運動をおこなうためのフラグ
    public bool stateOfMove = true;
    public bool stateOfMovingHalf = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            updown = true;                  //Switch to play mode
            Invoke("StopUpdown", span * 40);//Set stop time
        }

        if (updown == true)                 //While play mode
        {
            countdown -= Time.deltaTime;    //Run timer

            if (countdown <= 0.0f)          //When timer wakeup
            {
                countdown = span;           //Set timer again
                counter += 1;               //Add counter
                stateOfMovingHalf = false;
            }
            if (countdown <= span/2.0f){
                stateOfMovingHalf = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            StopUpdown();
        }
    }

    void StopUpdown()   //Init variables(stop completely)
    {
        countdown = 0f;
        updown = false;
        counter = 0;
    }
}