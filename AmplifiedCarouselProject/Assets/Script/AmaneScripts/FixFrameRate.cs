using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFrameRate : MonoBehaviour
{
    // Start is called before the first frame update
    public int fixedFrameRate = 60;
    void Start()
    {
        Application.targetFrameRate = fixedFrameRate;
    }
}
