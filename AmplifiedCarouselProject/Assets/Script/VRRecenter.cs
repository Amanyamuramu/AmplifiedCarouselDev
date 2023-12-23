using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRecenter : MonoBehaviour
{

    public KeyCode reloadKey = KeyCode.R; // このキーを押すとVR内のカメラ位置をリセンターする

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(reloadKey))
        {
            print("Recenter!");
            
        }
    }
}
