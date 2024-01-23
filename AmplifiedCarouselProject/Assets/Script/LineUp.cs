using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineUp : MonoBehaviour
{
    //高さ
    [SerializeField] float high;
    public float width = 0.26f;
    // 縦に配置する数
    public int vertical = 57;
    // 横に配置する数
    public int horizontal = 57;
    public GameObject cube;
    Vector3 pos;
    public TimerScript timerScript;

    void Start()
    {
        high = timerScript.stimulHeight;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pos = transform.position;
            for (int vi = 0; vi < vertical; vi++)
            {
                for (int hi = 0; hi < horizontal; hi++)
                {
                    GameObject copy = Instantiate(cube,
                        new Vector3(
                            pos.x + horizontal * width / 2 - hi * width - width / 2,
                            high,
                            pos.z + vertical * width / 2 - vi * width - width / 2
                        ),
                        Quaternion.Euler(90f, 0f, 0f));
                }
            }
        }
    }
}