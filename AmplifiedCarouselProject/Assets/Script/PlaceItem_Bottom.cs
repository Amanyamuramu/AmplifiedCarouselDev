using System.Collections.Generic;
using UnityEngine;

public class PlaceItem_Bottom : MonoBehaviour
{
    // アイテムのプレハブ
    [SerializeField] GameObject item;

    // アイテムを作る数 
    [SerializeField] int itemCount = 3000;

    public float height = 0.27f;
    public float density = 0.2f;

    // アイテムのインスタンス
    List<GameObject> items = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 左クリック  
        if (Input.GetMouseButtonDown(0))
        {
            // アイテムを全削除
            foreach (var i in items)
            {
                Destroy(i);
            }
            items.Clear();

            // ボックスサイズの半分
            Vector3 halfExtents = new Vector3(density, density, density);

            // アイテムを作る
            for (int i = 0; i < itemCount; i++)
            {
                // 10回試す
                for (int n = 0; n < 1000; n++)
                {
                    // ランダムの位置
                    Vector3 pos = Random.insideUnitCircle * 7;
                    pos.z = pos.y;
                    pos.y = height;

                    // ボックスとアイテムが重ならないとき
                    if (!Physics.CheckBox(pos, halfExtents, Quaternion.identity))
                    {
                        // アイテムをインスタンス化
                        items.Add(Instantiate(item, pos, Quaternion.Euler(90f, 0f, 0f)));
                        break;
                    }
                }
            }
        }
    }
}