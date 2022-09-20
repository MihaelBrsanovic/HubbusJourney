using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoboxManagement : MonoBehaviour
{
    public Sprite[] infosheets;
    public Button up, down;
    private int counter = 0;
    private void Start()
    {
        up.interactable = false;
    }
    public void Up()
    {
        if (counter != 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = infosheets[--counter];
            down.interactable = true;
        }
        if (counter == 0)
        {
            up.interactable = false;
        }
    }
    public void Down()
    {
        if (counter != infosheets.Length - 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = infosheets[++counter];
            up.interactable = true;
        }
        if (counter == infosheets.Length - 1)
        {
            down.interactable = false;
        }
    }
    public IEnumerator Infoloop()
    {
        for(int i=0; ;i++)
        {
            this.GetComponent<SpriteRenderer>().sprite = infosheets[i];
            if(i == 0 || i == 4) yield return new WaitForSeconds(9f);
            else yield return new WaitForSeconds(6f);
            if (i >= 4) i = -1;
        }
    }
}
