using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;
public class VideoTimeViewer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeText;

    private VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    private bool isPaused;
    private void Update()
    {
        timeText.text = videoPlayer.time.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                videoPlayer.Play();
                isPaused = false;
            }
            else
            {
                videoPlayer.Pause();
                isPaused = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            videoPlayer.time -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            videoPlayer.time += 1;
        }

    }


}
