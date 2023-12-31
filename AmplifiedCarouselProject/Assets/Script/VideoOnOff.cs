using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoOnOff : MonoBehaviour
{
    VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (video.isPlaying)
            {
                video.Pause(); // 動画を停止
            }
            else
            {
                video.Play(); // 動画を再生
            }
        }
    }
}