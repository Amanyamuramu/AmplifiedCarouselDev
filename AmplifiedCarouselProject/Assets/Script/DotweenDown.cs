using DG.Tweening;  //using DOTween
using UnityEngine;

public class DotweenDown : MonoBehaviour
{

    Vector3 mySelf;
    GameObject timerObject;
    TimerScript timerScript;
    private int counter;
    private int currentCounter;
    private float dist;

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

        if (currentCounter > counter)   //When timer wakeup
        {
            counter = currentCounter;   //Store counter to currentCounter
            var sequence = DOTween.Sequence();  //Make instance

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y + 0.4f, mySelf.z), 1.7f).SetEase(Ease.InOutQuad));   //Move outside

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), 1.7f).SetEase(Ease.InOutQuad));    //Back to init position

            sequence.Play();    //Do instance
        }
        else if (currentCounter == 0)
        {
            counter = 0;    //Init counter
        }
    }
}
