using UnityEngine;

public class AlfaPoint : MonoBehaviour
{
    private float transparency;
    private float a = 1f;
    private Color color;
    GameObject timerObject;
    TimerScript timerScript;

    void Start()
    {
        color = gameObject.GetComponent<Renderer>().material.color;
        timerObject = GameObject.Find("Timer"); //Find Timer object
        timerScript = timerObject.GetComponent<TimerScript>();  //Store script
    }

    void Update()
    {
        transparency = timerScript.transparency;   //Store variable
        color.a = transparency / 100;
        gameObject.GetComponent<Renderer>().material.color = color; //Set color
    }
}