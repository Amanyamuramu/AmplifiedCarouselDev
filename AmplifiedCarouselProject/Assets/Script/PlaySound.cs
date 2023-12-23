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
            GetComponent<AudioSource>().Play();  // Œø‰Ê‰¹‚ð–Â‚ç‚·
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
        GetComponent<AudioSource>().Pause();  // Œø‰Ê‰¹‚ðŽ~‚ß‚é
    }
}