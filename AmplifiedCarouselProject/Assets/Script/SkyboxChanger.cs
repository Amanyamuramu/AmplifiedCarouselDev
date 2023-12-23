using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material skybox01;
    public Material skybox02;
    public Material skybox03;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skybox01;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RenderSettings.skybox = skybox01;
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RenderSettings.skybox = skybox02;
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RenderSettings.skybox = skybox03;
        }
    }
}
