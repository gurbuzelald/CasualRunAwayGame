using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAudioData", menuName = "AudioData")]
public class AudioData : ScriptableObject
{
    public AudioClip gameMusic;
    public AudioClip menuMusic;
    public AudioClip endMusic;
    public AudioClip winMusic;
}
