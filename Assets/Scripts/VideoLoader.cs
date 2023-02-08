using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Video;
public class VideoLoader : MonoBehaviour
{
    public static Dictionary<string, VideoClip> cache;

    public static event System.Action<VideoClip> videoLoaded;

}
