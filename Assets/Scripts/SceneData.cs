using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "SceneData", menuName = "ScriptableObjects/SceneData")]
public class SceneData : ScriptableObject
{
    public string videoClipName;

    public float[] sentenceStartTimes;
}
