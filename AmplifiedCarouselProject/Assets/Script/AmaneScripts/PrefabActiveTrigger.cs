using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrefabActiveTrigger : MonoBehaviour
{
    // ボタンとオブジェクトの配列をインスペクタから設定
    [SerializeField] private Button[] buttons;
    [SerializeField] private GameObject[] objectsToShow;

    private void Start()
    {
        // 配列の長さが異なる場合はエラーをログに出力
        if (buttons.Length != objectsToShow.Length)
        {
            Debug.LogError("Buttons and Objects to Show arrays must be of the same length.");
            return;
        }

        // 各ボタンにリスナーを追加
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // ループ内で使用するために、現在のインデックスをローカル変数にコピー
            buttons[i].onClick.AddListener(() => ToggleObjectVisibility(index));
        }
    }

    // オブジェクトの表示非表示を切り替えるメソッド
    // 対象のオブジェクトのインデックスを引数として受け取る
    private void ToggleObjectVisibility(int index)
    {
        // 配列の範囲内であることを確認
        if (index >= 0 && index < objectsToShow.Length)
        {
            objectsToShow[index].SetActive(!objectsToShow[index].activeSelf);
        }
    }
}