using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenScript : MonoBehaviour
{
    public void Continue()
    {
        gameObject.SetActive(false);
    }
    public void Quit()
    {
        // Battle.quit = true;
        SceneManager.LoadScene(0);
    }
    public void OnEnable()
    {
        Time.timeScale = 0f;
        Time.fixedDeltaTime = 0f;
    }
    public void OnDisable()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
    }
}
