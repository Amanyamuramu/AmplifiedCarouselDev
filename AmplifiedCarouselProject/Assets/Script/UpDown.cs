using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{

    public float nowPosi;
    private bool updown = false;

    void Start()
    {
        nowPosi = this.transform.position.y;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            updown = true;
            Invoke("StopUpdown", 10f);
        }

        if (updown == true) {
            transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time / 3, 0.3f), transform.position.z);
        }
    }

    void StopUpdown()
    {
        updown = false;
    }

}