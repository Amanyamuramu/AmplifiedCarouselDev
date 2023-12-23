using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePoint : MonoBehaviour
{
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.z = Random.Range(0f, 360f);
            myTransform.localEulerAngles = localAngle;
        }
    }
}
