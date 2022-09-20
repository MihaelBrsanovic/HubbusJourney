using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenScript : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void ZumMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
