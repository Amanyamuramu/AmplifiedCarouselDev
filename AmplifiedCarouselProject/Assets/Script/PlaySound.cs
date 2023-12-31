using UnityEngine;

public class PlaySound : MonoBehaviour
{

    private bool updown = false;
    private float countdown = 17.5f;
    private float countup = 0.0f;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            updown = true;
            Invoke("StopUpdown", countdown);
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }

        if (updown == true)
        {
            countup += Time.deltaTime;
        }
    }

    void StopUpdown()
    {
        countup = 0f;
        updown = false;
        GetComponent<AudioSource>().Pause();  // 効果音を止める
    }
}