using UnityEngine;
using UnityEngine.Audio;//Für die Änderung von Audio
using UnityEngine.SceneManagement;//Damit ich SceneManager.LoadScene benutzen kann


public class Optionen : MonoBehaviour
{
    public new AudioMixer audio;

    public void SetVolume(float volume)
    {
        audio.SetFloat("volume", volume);
        if (volume <= -20) audio.SetFloat("volume", -80);
    }
    public void Fullscreen(bool full)
    {
        Screen.fullScreen = full;
    }
    public void Cancel()
    {
        GameObject info = GameObject.FindGameObjectWithTag("MenuInfo");
        SceneManager.LoadScene(info.tag);
    }
}
