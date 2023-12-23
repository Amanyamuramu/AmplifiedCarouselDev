using UnityEngine;

public class AlfaChange : MonoBehaviour
{

    private bool alfa = true;
    private int counter;
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
        counter = timerScript.counter;   //Store variable
        if(counter == 0)
        {
            color.a = 1f;
            gameObject.GetComponent<Renderer>().material.color = color;
        }
        else{
            color.a = 0f;
            gameObject.GetComponent<Renderer>().material.color = color;
        }



    }
}