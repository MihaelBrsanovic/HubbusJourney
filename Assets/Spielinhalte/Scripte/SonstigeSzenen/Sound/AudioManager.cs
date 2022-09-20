using Unity.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    void Awake()//Vor Start
    {
        foreach(Sound s in sounds)//Macht die änderungen auf allen sounds. Die Einstellungen, die du vor dem Start im Sound geändert hast, werden in den AudioSource reinkopiert.
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.pitch = s.pitch;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.output;
        }
    }

    public void Play (string name)//Spielt den Sound den du haben willst durch den Namen
    {
        Sound s=Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    public void Stop(string name)//Spielt den Sound den du haben willst durch den Namen
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
