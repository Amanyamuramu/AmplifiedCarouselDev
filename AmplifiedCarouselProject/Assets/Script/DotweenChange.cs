using DG.Tweening;  //using DOTween
using UnityEngine;

public class DotweenChange : MonoBehaviour
{

    Vector3 mySelf;
    private float amp;

    GameObject timerObject;
    TimerScript timerScript;
    private int counter;
    private int currentCounter;
    private float dist;
    Vector3 Horse;
    Vector3 toHorse;
    public float halfTime = 1.7f;
    private int pi;

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
        pi = timerScript.pi;    //Store variable;

        toHorse = Horse - mySelf;   //Culc vector to Camera
        //toHorse *= amp / Mathf.Pow(toHorse.sqrMagnitude, 0.5f); //Amplify vector
        toHorse *= amp / Mathf.Pow(dist, 0.5f); //Amplify vector

        Horse = GameObject.Find("Camera").transform.position;   //Find Camera Position
        Horse.y = 0f;
        mySelf.y = 0f;
        dist = Vector3.Distance(mySelf, Horse); //Measure distance between Camera and mySelf

        switch (pi)
        {
            case 0:
                pi00();
                break;
            case 1:
                pi05();
                break;
            case 2:
                pi10();
                break;
            default:
                break;
        }
    }

    void pi00()
    {
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
            var sequence = DOTween.Sequence();  //Make instance
            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), 0f).SetEase(Ease.InOutQuad));    //Back to init position
            sequence.Join(this.transform.DOScale(1f, 0f).SetEase(Ease.InOutQuad));    //Transform scale down
        }
    }

    void pi05()
    {
        if (currentCounter > counter)   //When timer wakeup
        {
            counter = currentCounter;   //Store counter to currentCounter
            var sequence = DOTween.Sequence();  //Make instance

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), halfTime/2).SetEase(Ease.InOutQuad));    //Stay init position
            sequence.Join(this.transform.DOScale(1f, halfTime/2).SetEase(Ease.InOutQuad));    //Stay init scale

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x - toHorse.x, mySelf.y, mySelf.z - toHorse.z), halfTime).SetEase(Ease.InOutQuad));   //Move outside
            sequence.Join(this.transform.DOScale(Mathf.Pow(amp * 15f / dist, 0.25f), halfTime).SetEase(Ease.InOutQuad));  //Transform scale up

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), halfTime).SetEase(Ease.InOutQuad));    //Back to init position
            sequence.Join(this.transform.DOScale(1f, halfTime).SetEase(Ease.InOutQuad));    //Transform scale down

            sequence.Play();    //Do instance
        }
        else if (currentCounter == 0)
        {
            counter = 0;    //Init counter
            var sequence = DOTween.Sequence();  //Make instance
            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), 0f).SetEase(Ease.InOutQuad));    //Back to init position
            sequence.Join(this.transform.DOScale(1f, 0f).SetEase(Ease.InOutQuad));    //Transform scale down
        }
    }

    void pi10()
    {
        if (currentCounter > counter)   //When timer wakeup
        {
            counter = currentCounter;   //Store counter to currentCounter
            var sequence = DOTween.Sequence();  //Make instance
            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), halfTime).SetEase(Ease.InOutQuad));    //Back to init position
            sequence.Join(this.transform.DOScale(1f, halfTime).SetEase(Ease.InOutQuad));    //Transform scale down

            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x - toHorse.x, mySelf.y, mySelf.z - toHorse.z), 1.7f).SetEase(Ease.InOutQuad));   //Move outside
            sequence.Join(this.transform.DOScale(Mathf.Pow(amp * 15f / dist, 0.25f), halfTime).SetEase(Ease.InOutQuad));  //Transform scale up

            sequence.Play();    //Do instance
        }
        else if (currentCounter == 0)
        {
            counter = 0;    //Init counter
            var sequence = DOTween.Sequence();  //Make instance
            sequence.Append(this.transform.DOMove(new Vector3(mySelf.x - toHorse.x, mySelf.y, mySelf.z - toHorse.z), 0f).SetEase(Ease.InOutQuad));   //Move outside
            sequence.Join(this.transform.DOScale(Mathf.Pow(amp * 15f / dist, 0.25f), 0f).SetEase(Ease.InOutQuad));  //Transform scale up
        }
    }
}
