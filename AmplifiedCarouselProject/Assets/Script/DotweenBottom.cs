using DG.Tweening;  //using DOTween
using UnityEngine;

public class DotweenBottom : MonoBehaviour
{

    Vector3 mySelf;
    public float amp = 0.23f;

    GameObject timerObject;
    GameObject experimentObject;
    TimerScript timerScript;
    ExperimentScript experimentScript;
    public int counter;
    public int currentCounter;
    public int experiment;

    void Start()
    {
        mySelf = this.transform.position;   //Store init position
        timerObject = GameObject.Find("Timer"); //Find Timer object
        timerScript = timerObject.GetComponent<TimerScript>();  //Store script
        experimentObject = GameObject.Find("Experiment");//Find experimentObject;
        experimentScript = experimentObject.GetComponent<ExperimentScript>();//Store script
        counter = 0;    //Init counter
        DOTween.SetTweensCapacity(tweenersCapacity: 25600, sequencesCapacity: 10240);
    }

    void Update()
    {
        Vector3 Horse = GameObject.Find("Camera").transform.position;   //Find Camera Position
        Vector3 toHorse = Horse - mySelf;   //Culc vector to Camera
        toHorse *= amp / Mathf.Pow(toHorse.sqrMagnitude, 0.5f); //Amplify vector

        currentCounter = timerScript.counter;   //Store variable
        experiment = experimentScript.deg;  //Store variable;

        if(experiment == 0)
        {
            if (currentCounter > counter)   //When timer wakeup
            {
                counter = currentCounter;   //Store counter to currentCounter
                var sequence = DOTween.Sequence();  //Make instance
                sequence.Append(this.transform.DOMove(new Vector3(mySelf.x - toHorse.x, mySelf.y, mySelf.z - toHorse.z), 1.7f).SetEase(Ease.InOutQuad));   //Move outside
                sequence.Append(this.transform.DOMove(new Vector3(mySelf.x, mySelf.y, mySelf.z), 1.7f).SetEase(Ease.InOutQuad));    //Back to init position
                sequence.Play();    //Do instance
            }
            else if (currentCounter == 0)
            {
                counter = 0;    //Init counter
            }
        }else if(experiment == 1)
        {
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
}
