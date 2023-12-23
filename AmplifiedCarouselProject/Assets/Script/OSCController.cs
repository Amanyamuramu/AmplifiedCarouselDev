using UnityEngine;
using System.Collections;

public class OSCController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // this line triggers the magic
        OSCHandler.Instance.Init();

        int testInteger = 54321;
        OSCHandler.Instance.SendMessageToClient("myRemoteLocation", "127.0.0.1:12000", testInteger);

    }

    // Update is called once per frame
    void Update()
    {
        //int testInteger = 54321;
        int random = Random.Range(0, 10000);

        Vector3 floor = GameObject.Find("TrackerFloor").transform.position;
        Vector3 horse = GameObject.Find("TrackerHorse").transform.position;

        GameObject.Find("TrackerFloor").transform.position = new Vector3(floor.x, floor.y, floor.z);
        GameObject.Find("TrackerHorse").transform.position = new Vector3(horse.x, horse.y, horse.z);

        int diff_x = (int)((floor.x - horse.x) * 10000);
        int diff_y = (int)((floor.z - horse.z) * 10000);

        int diff = (diff_x * 100000) + diff_y;

        //string diff = diff_x.ToString();

        OSCHandler.Instance.SendMessageToClient("myRemoteLocation", "127.0.0.1:12000", diff);
        Debug.Log(diff);

    }
}