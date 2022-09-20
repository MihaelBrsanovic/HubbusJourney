using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
public class TimeScript : MonoBehaviour
{
    public static void ChangeTimeScale(float multiplicator)
    {
        Time.timeScale *= multiplicator;
        Time.fixedDeltaTime *= multiplicator;
    }
    public static IEnumerator Normalize(float speed)
    {
        float timeScaleAbweichung = (1f - Time.timeScale) / 10;
        // float fixedScaleAbweichung = (0.02f - ResourceScript.fixedTimeScale) / 10;
        for (int i = 0; i < 10; i++)
        {
            Time.timeScale += timeScaleAbweichung;
            // Time.fixedDeltaTime += fixedScaleAbweichung;
            yield return new WaitForSeconds(speed);
        }
        Time.timeScale = 1f;
        // Time.fixedDeltaTime = ResourceScript.fixedTimeScale;
    }
}
