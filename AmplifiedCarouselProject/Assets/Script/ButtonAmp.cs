using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを使うため追加

public class ButtonAmp : MonoBehaviour
{
    [SerializeField] private Text suuji_text;//Text型の変数suuji_textを宣言
    public int suuji;

    void Start()
    {
    }

    //ボタンを押したら実行する関数　実行するためにはボタンへ関数登録が必要
    //int型の引数numberを宣言
    public void Push_Button(int number)
    {
        suuji_text.text = "" + number;//suuji_textに引数の数値を代入
        suuji = number;
    }
}