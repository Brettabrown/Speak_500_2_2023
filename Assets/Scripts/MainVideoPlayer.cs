using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class MainVideoPlayer : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer videoPlayer;

    [SerializeField]
    private GameObject pauseButton;

    [SerializeField]
    private GameObject playButton;

    [SerializeField]
    private RawImage rawImage;

    [SerializeField]
    private MainTextArea mainTextArea;

    public double Time { get { return videoPlayer.time; } }
    public VideoClip Clip
    {
        get { return videoPlayer.clip; }
        set { videoPlayer.clip = value; videoPlayer.Stop(); videoPlayer.Play(); }
    }

    public void SetURL(string url)
    {
        videoPlayer.url = url;
        videoPlayer.Play();
        rawImage.enabled = true; 
    }

    private void Awake()
    {
        ClickableSentence.Clicked += _ =>
        {
            print("F");
            videoPlayer.Pause();
            pauseButton.GetComponent<Button>().enabled = false;
            playButton.GetComponent<Button>().enabled = false;
            pauseButton.SetActive(false);
            playButton.SetActive(true);
        };
    }

    public void WordEnd()
    {
        pauseButton.GetComponent<Button>().enabled = true;
        playButton.GetComponent<Button>().enabled = true;
    }

    public void Pause()
    {
        pauseButton.SetActive(false);
        playButton.SetActive(true);
        videoPlayer.Pause();
    }

    public void Play()
    {
        pauseButton.SetActive(true);
        playButton.SetActive(false);
        videoPlayer.Play();
    }

    public void Forward()
    {
        videoPlayer.Pause();
        videoPlayer.time += 2.0;
        videoPlayer.Play();
        pauseButton.SetActive(true);
        playButton.SetActive(false);
    }

    public void Back()
    {
        videoPlayer.Pause();
        videoPlayer.time -= 2.0;
        videoPlayer.Play();
        pauseButton.SetActive(true);
        playButton.SetActive(false);
    }

    public void VideoOn()
    {
        rawImage.enabled = true;
        mainTextArea.HideAll();
    }

    public void VideoOff()
    {
        rawImage.enabled = false;
        mainTextArea.ShowAll();
    }

    public void Mute()
    {
        videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0));
    }

    public void LowerSound()
    {
        videoPlayer.SetDirectAudioMute(0, false);
        videoPlayer.SetDirectAudioVolume(0, videoPlayer.GetDirectAudioVolume(0) - 0.1f);
        videoPlayer.SetDirectAudioVolume(0, Mathf.Clamp01(videoPlayer.GetDirectAudioVolume(0)));
    }

    public void RaiseSound()
    {
        videoPlayer.SetDirectAudioMute(0, false);
        videoPlayer.SetDirectAudioVolume(0, videoPlayer.GetDirectAudioVolume(0) + 0.1f);
        videoPlayer.SetDirectAudioVolume(0, Mathf.Clamp01(videoPlayer.GetDirectAudioVolume(0)));
    }

}
