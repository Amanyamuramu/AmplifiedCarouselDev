using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    //�J�E���g�A�b�v
    private float countup = 0.0f;

    private bool updown = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            updown = true;
            Invoke("StopUpdown", 17.5f);
        }

        if (updown == true)
        {
            //���Ԃ��J�E���g����
            countup += Time.deltaTime;
            Debug.Log(countup);

        }
    }

    void StopUpdown()
    {
        countup = 0f;
        updown = false;
    }
}