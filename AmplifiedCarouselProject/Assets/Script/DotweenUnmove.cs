using DG.Tweening;  //using DOTween
using UnityEngine;

public class DotweenUnmove : MonoBehaviour
{

    Vector3 mySelf;
    public float amp = 0.23f;

    GameObject timerObject;
    TimerScript timerScript;
    public int counter;
    public int currentCounter;

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
        Vector3 Horse = GameObject.Find("Camera").transform.position;   //Find Camera Position
        Vector3 toHorse = Horse - mySelf;   //Culc vector to Camera
        toHorse *= amp / Mathf.Pow(toHorse.sqrMagnitude, 0.5f); //Amplify vector

        currentCounter = timerScript.counter;   //Store variable

        if (currentCounter > counter)   //When timer wakeup
        {
            counter = currentCounter;   //Store counter to currentCounter
            var sequence = DOTween.Sequence();  //Make instance
            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), 1.7f).SetEase(Ease.InOutQuad));    //Back to init position
            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x - toHorse.x, mySelf.y, mySelf.z - toHorse.z), 1.7f).SetEase(Ease.InOutQuad));   //Move outside
            sequence.Play();    //Do instance
        }
        else if (currentCounter == 0)
        {
            counter = 0;    //Init counter
            this.transform.position = new Vector3(mySelf.x - toHorse.x, mySelf.y, mySelf.z - toHorse.z);   //Move outside
        }
    }
}
