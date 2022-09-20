using UnityEngine;
using UnityEngine.SceneManagement;//Damit ich SceneManager.LoadScene benutzen kann

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject optionen;
    public GameObject credits;
    public GameObject tastenbelegung;
    public void Start()
    {
        FindObjectOfType<AudioManager>().Play("Shop-Musik");//Musik implementieren
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
    }
    public void NewStart()
    {
        Lesen.Neu();
        this.SetFalse();
        tastenbelegung.SetActive(true);
    }
    public void Continue()
    {
        //File loaden
        SceneManager.LoadScene("KampfSzene");
    }

    public void Options()
    {
        this.SetFalse();
        optionen.SetActive(true);
    }
    public void Credits()
    {
        this.SetFalse();
        credits.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void CancelC()
    {
        this.SetFalse();
        menu.SetActive(true);
    }
    public void SetFalse()
    {
        credits.SetActive(false);
        optionen.SetActive(false);
        menu.SetActive(false);
    }
    public void StartLiveDemo()
    {
        SceneManager.LoadScene(3);
    }
}
