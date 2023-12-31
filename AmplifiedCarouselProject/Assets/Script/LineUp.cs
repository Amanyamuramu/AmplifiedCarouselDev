using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineUp : MonoBehaviour
{
    //高さ
    public float high;
    //オブジェクト間の幅
    public float width = 0.26f;
    //上から見て縦、Z軸のオブジェクトの量
    public int vertical = 57;
    //上から見て横、X軸のオブジェクトの量
    public int horizontal = 57;

    //Prefabを入れる欄を作る
    public GameObject cube;

    //位置を入れる変数
    Vector3 pos;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //このスクリプトを入れたオブジェクトの位置
            pos = transform.position;

            //Z軸にverticalの数だけ並べる
            for (int vi = 0; vi < vertical; vi++)
            {
                //X軸にhorizontalの数だけ並べる
                for (int hi = 0; hi < horizontal; hi++)
                {
                    //PrefabのCubeを生成する
                    GameObject copy = Instantiate(cube,
                        //生成したものを配置する位置
                        new Vector3(
                            //X軸
                            pos.x + horizontal * width / 2 - hi * width - width / 2,
                            //Y軸
                            high,
                            //Z軸
                            pos.z + vertical * width / 2 - vi * width - width / 2
                        //Quaternion.identityは無回転を指定する
                        ), Quaternion.Euler(90f, 0f, 0f));
                }
            }
        }
    }
}