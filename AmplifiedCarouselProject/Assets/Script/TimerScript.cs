using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    //�J�E���g�A�b�v
    public float span = 3.5f;
    public bool updown = false;
    public float countdown = 0.0f;
    public int counter = 0;
    public float amp = 1f;
    public int pi = 0;
    public int transparency = 100;

    public bool stateOfMove = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            updown = true;  //Switch to play mode
            Invoke("StopUpdown", span*40);   //Set stop time
        }

        if (updown == true) //While play mode
        {
            countdown -= Time.deltaTime;    //Run timer

            if(countdown <= 0.0f)   //When timer wakeup
            {
                countdown = span;   //Set timer again
                counter += 1;   //Add counter
            }
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            StopUpdown();
        }
    }

    void StopUpdown()   //Init variables
    {
        countdown = 0f;
        updown = false;
        counter = 0;
    }
}