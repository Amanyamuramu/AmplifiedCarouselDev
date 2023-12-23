using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SerialDOTween : MonoBehaviour
{
    SerialPortUtility.SerialPortUtilityPro serialPort;
    private string _on = "1";
    private string _off = "0";

    GameObject timerObject;
    TimerScript timerScript;
    public int counter;
    public int currentCounter;

    void Awake()
    {
        serialPort = this.GetComponent<SerialPortUtility.SerialPortUtilityPro>();
        timerObject = GameObject.Find("Timer"); //Find Timer object
        timerScript = timerObject.GetComponent<TimerScript>();  //Store script
        counter = 0;    //Init counter
    }

    // Update is called once per frame
    void Update()
    {
        currentCounter = timerScript.counter;   //Store variable

        if (currentCounter > counter)   //When timer wakeup
        {
            counter = currentCounter;   //Store counter to currentCounter
            if (serialPort != null)
            {
                if (serialPort.IsOpened())
                {
                    serialPort.WriteCR(_on);
                    Debug.Log("Serial Send");
                }
            }
        }
        else if (currentCounter == 0)
        {
            counter = 0;    //Init counter
        }
    }


    public void RelayOn()
    {
        if (serialPort != null)
        {
            if (serialPort.IsOpened())
            {
                serialPort.WriteCR(_on);
            }
        }
    }

    public void RelayOff()
    {
        if (serialPort != null)
        {
            if (serialPort.IsOpened())
            {
                serialPort.WriteCR(_off);
            }
        }
    }
}
