using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentScript : MonoBehaviour
{
    public int deg = 0;

    // Start is called before the first frame update
    void Start()
    {
        deg = GUILayout.SelectionGrid(deg, new string[] { "0", "90", "180" }, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
