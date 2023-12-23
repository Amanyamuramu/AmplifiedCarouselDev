using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SerialHandler : MonoBehaviour
{
    SerialPortUtility.SerialPortUtilityPro serialPort;
    private string _on = "1";
    private string _off = "0";

    void Awake()
    {
        serialPort = this.GetComponent<SerialPortUtility.SerialPortUtilityPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpened())
                {
                    serialPort.WriteCR(_on);
                }
            }
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
