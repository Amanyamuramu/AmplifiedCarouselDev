using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public float floorHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 floor = GameObject.Find("TrackerFloor").transform.position;
        this.transform.position = new Vector3(floor.x, floorHeight, floor.z);
    }
}
