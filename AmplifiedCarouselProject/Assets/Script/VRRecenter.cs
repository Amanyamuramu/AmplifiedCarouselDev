using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRecenter : MonoBehaviour
{

    public KeyCode reloadKey = KeyCode.R; // ���̃L�[��������VR���̃J�����ʒu�����Z���^�[����

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(reloadKey))
        {
            print("Recenter!");
            
        }
    }
}
