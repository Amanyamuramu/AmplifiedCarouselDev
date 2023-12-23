using UnityEngine;

public class SoundChange : MonoBehaviour
{
    private int counter;
    GameObject timerObject;
    TimerScript timerScript;
    AudioSource audioSource;

    void Start()
    {
        timerObject = GameObject.Find("Timer"); //Find Timer object
        timerScript = timerObject.GetComponent<TimerScript>();  //Store script
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        counter = timerScript.counter;   //Store variable
        if (counter == 0)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = 1f;
        }



    }
}