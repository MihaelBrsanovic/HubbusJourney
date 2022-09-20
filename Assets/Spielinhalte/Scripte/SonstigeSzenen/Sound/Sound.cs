using Unity.Audio;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    //Die einstellungen, die du vor dem Start machen kannst und dan ins AudioSource implementiert werden.
    public string name;

    public AudioClip clip;

    public AudioMixerGroup output;

    [Range(0f,1f)]
    public float volume;

    [Range(-3f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;

    public bool loop;
    
}
