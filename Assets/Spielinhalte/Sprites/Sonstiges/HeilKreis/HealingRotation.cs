using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingRotation : MonoBehaviour//Die Rotation für die Heilungsfähigkeit
{
    float add = 0;
    // Update is called once per frame
    void Update()
    {
        add -= 1f;
        transform.eulerAngles = new Vector3(0, 0, add);
    }
    void SetInactive()
    {
        this.gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        Invoke("SetInactive", 7.5f);
    }
}
