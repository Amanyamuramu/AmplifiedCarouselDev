using DG.Tweening;  //using DOTween
using UnityEngine;

public class DotweenMove : MonoBehaviour
{

    Vector3 mySelf;
    private float amp;

    GameObject timerObject;
    TimerScript timerScript;
    private int counter;
    private int currentCounter;
    public float dist;
    Vector3 Horse;
    Vector3 toHorse;
    public float halfTime = 1.75f;
    //public float halfTime = 1.3f;

    void Start()
    {
        mySelf = this.transform.position;   //Store init position
        timerObject = GameObject.Find("Timer"); //Find Timer object
        timerScript = timerObject.GetComponent<TimerScript>();  //Store script
        counter = 0;    //Init counter
        DOTween.SetTweensCapacity(tweenersCapacity: 25600, sequencesCapacity: 10240);
    }

    void Update()
    {


        currentCounter = timerScript.counter;   //Store variable
        amp = timerScript.amp;  //Store variable;

        toHorse = Horse - mySelf;   //Culc vector to Camera
        //toHorse *= amp / Mathf.Pow(toHorse.sqrMagnitude, 0.5f); //Amplify vector
        toHorse *= amp / Mathf.Pow(dist, 0.5f); //Amplify vector//Ampを制御

        Horse = GameObject.Find("Camera").transform.position;   //Find Camera Position
        Horse.y = 0f;
        mySelf.y = 0f;
        dist = Vector3.Distance(mySelf, Horse); //Measure distance between Camera and mySelf

        if (currentCounter > counter)   //When timer wakeup
        {
            counter = currentCounter;   //Store counter to currentCounter
            var sequence = DOTween.Sequence();  //Make instance

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x - toHorse.x, mySelf.y, mySelf.z - toHorse.z), halfTime).SetEase(Ease.InOutQuad));   //Move outside
            sequence.Join(this.transform.DOScale(Mathf.Pow(amp * 15f / dist, 0.25f), halfTime).SetEase(Ease.InOutQuad));  //Transform scale up

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), halfTime).SetEase(Ease.InOutQuad));    //Back to init position
            sequence.Join(this.transform.DOScale(1f, halfTime).SetEase(Ease.InOutQuad));    //Transform scale down

            sequence.Play();    //Do instance
        }
        else if (currentCounter == 0)
        {
            counter = 0;    //Init counter
        }
    }
}
